using System.Collections.Generic;
using Grpc.Net.Client;
using TestDb2;

namespace Launcher.Models
{
    public class MainWindowModel
    {
        private static readonly GrpcChannel _channel = GrpcChannel.ForAddress("https://localhost:5001");

        public RemoteShop.RemoteShopClient _client = new RemoteShop.RemoteShopClient(_channel);
        
        public List<ProductModel> Products;

    }
}