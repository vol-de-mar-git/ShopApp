
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestDb2.Database;

namespace TestDb2
{
    public class ShopService : RemoteShop.RemoteShopBase
    {
        private ShopDbContext _context;

        public ShopService(ShopDbContext dbContext)
        {
            _context = dbContext;
        }
        
        public override async Task<ProductModel> GetProductById(ProductByIdRequest request, ServerCallContext context)
        {
            var product = await _context.Products.FindAsync(Guid.Parse(request.ProductId));

            var result = new ProductModel
            {
                Id = product.Id.ToString(),
                Name = product.Name,
                Brand = new BrandModel {Id = product.BrandId.ToString(), Name = product?.Brand.Name},
                Designer = new DesignerModel{Id = product.DesignerId.ToString(),Name = product.Designer.Name,LastName = product.Designer.LastName, Country = new CountryModel{Id = product.Designer.Country.Id.ToString(), Name = product.Designer.Country.Name}},
                Category = new CategoryModel{Id = product.CategoryId.ToString(), Name = product.Category.Name},
                Count = product.Count,
                Price = product.Price
                
            };

            return await Task.FromResult(result);
        }

        public override async Task<ProductsResponse> GetProducts(Empty request, ServerCallContext context)
        {
            var result = new ProductsResponse()
            {
                Products =
                {
                    _context.Products.Select(product => new ProductModel() {
                        Id = product.Id.ToString(),
                        Name = product.Name,
                        Brand = new BrandModel {Id = product.BrandId.ToString(), Name = product.Brand.Name},
                        Designer = new DesignerModel{Id = product.DesignerId.ToString(),Name = product.Designer.Name,LastName = product.Designer.LastName, Country = new CountryModel{Id = product.Designer.Country.Id.ToString(), Name = product.Designer.Country.Name}},
                        Category = new CategoryModel{Id = product.CategoryId.ToString(), Name = product.Category.Name},
                        Count = product.Count,
                        Price = product.Price,
                        Country = new CountryModel{Id = product.CountryId.ToString(), Name = product.Country.Name}

                    })
                }
            };
            
            return await Task.FromResult(result);
        }

        public override async Task<Empty> AddProduct(ProductModel request, ServerCallContext context)
        {
            Guid designerId;

            if (string.IsNullOrEmpty(request.Designer.LastName))
            {
                designerId = _context.Designers.FirstOrDefault(x => x.Name == request.Designer.Name).Id;
            }
            else
            {
                designerId = _context.Designers
                    .FirstOrDefaultAsync(
                        x => x.Name == request.Designer.Name && x.LastName == request.Designer.LastName).Result.Id;
            }
            
            await _context.Products.AddAsync(new Product()
            {
                Name = request.Name,
                Id = Guid.NewGuid(),
                Price = request.Price,
                Count = request.Count,
                DesignerId = designerId,
                CategoryId = _context.Categories.FirstOrDefaultAsync(x => x.Name == request.Category.Name).Result.Id,
                CountryId = _context.Countries.FirstOrDefaultAsync(x => x.Name == request.Country.Name).Result.Id,
                BrandId = _context.Brands.FirstOrDefaultAsync(x => x.Name == request.Brand.Name).Result.Id,
            });

            await _context.SaveChangesAsync();

            return await Task.FromResult<Empty>(new Empty());
        }

        public override async Task<Empty> BuyProductById(ProductByIdRequest request, ServerCallContext context)
        {
            var product = await _context.Products.FindAsync(Guid.Parse(request.ProductId));

            product.Count--;

            await _context.SaveChangesAsync();

            return await Task.FromResult<Empty>(new Empty());
        }

        public override async Task<Empty> DeleteProductById(ProductByIdRequest request, ServerCallContext context)
        {
            
            var product = await _context.Products.FindAsync(Guid.Parse(request.ProductId));

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();
            
            return await Task.FromResult<Empty>(new Empty());
        }

        
        
        public override Task<NamesModel> GetNames(NamesRequest request, ServerCallContext context)
        {
            List<string> names = request.Name switch
            {
                "Country" => _context.Countries.Select(x => x.Name).ToList(),
                "Designer" => _context.Designers.Select(x => x.Name).ToList(),
                "Category" => _context.Categories.Select(x => x.Name).ToList(),
                "Brand" => _context.Brands.Select(x => x.Name).ToList(),
            };

            var result = new NamesModel();
            result.Names.AddRange(names);

            return Task.FromResult<NamesModel>(result);
        }
    }
}