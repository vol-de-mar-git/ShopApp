// See https://aka.ms/new-console-template for more information

using System;
using System.Text.Json.Serialization;
using Grpc.Net.Client;
using TestDb2;

var brand = new BrandModel
{
    Name = "Gucci"
};

Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://localhost:5001");

var client = new RemoteShop.RemoteShopClient(channel);

var t = client.GetNames(new NamesRequest {Name = "Brand"});

Console.WriteLine(t.Names.Count);

    /*Console.WriteLine("Send product request");

var replay = await client.GetProductByIdAsync(new ProductByIdRequest{ ProductId = "8D18FDF4-A376-4488-9544-6D13BF82E66C"}).ResponseAsync;

await client.AddProductAsync(new ProductModel
{
    Name = "Zalupa",
    Price = 999,
    Count = 10,
    Brand = brand,
});


Console.WriteLine("Get product response:");
Console.Write($"{replay.Id} \n{replay.Name} \n{replay.Country.Name}");

*/


Console.ReadKey();