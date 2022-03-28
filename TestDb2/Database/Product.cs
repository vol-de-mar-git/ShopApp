using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDb2.Database
{
    public class Product
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Product's name")]
        public string Name { get; set; }

        [Display(Name = "Product's price")] 
        public double Price { get; set; }
        
        public int Count { get; set; }

        #region Navigation

        public Guid? DesignerId { get; set; }
        
        public Designer Designer { get; set; }
        
        public Guid? CategoryId { get; set; }
        
        public Category Category { get; set; }
        
        
        public Guid? CountryId { get; set; }
        
        public Country Country { get; set; }
        
        public Guid? BrandId { get; set; }
        
        public Brand Brand { get; set; }

        #endregion
        
        
    }
}