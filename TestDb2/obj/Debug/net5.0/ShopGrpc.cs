// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: shop.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TestDb2 {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class RemoteShop
  {
    static readonly string __ServiceName = "greet.RemoteShop";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::TestDb2.ProductByIdRequest> __Marshaller_greet_ProductByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TestDb2.ProductByIdRequest.Parser));
    static readonly grpc::Marshaller<global::TestDb2.ProductModel> __Marshaller_greet_ProductModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TestDb2.ProductModel.Parser));
    static readonly grpc::Marshaller<global::TestDb2.Empty> __Marshaller_greet_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TestDb2.Empty.Parser));
    static readonly grpc::Marshaller<global::TestDb2.ProductsResponse> __Marshaller_greet_ProductsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TestDb2.ProductsResponse.Parser));
    static readonly grpc::Marshaller<global::TestDb2.NamesRequest> __Marshaller_greet_NamesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TestDb2.NamesRequest.Parser));
    static readonly grpc::Marshaller<global::TestDb2.NamesModel> __Marshaller_greet_NamesModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TestDb2.NamesModel.Parser));

    static readonly grpc::Method<global::TestDb2.ProductByIdRequest, global::TestDb2.ProductModel> __Method_GetProductById = new grpc::Method<global::TestDb2.ProductByIdRequest, global::TestDb2.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_greet_ProductByIdRequest,
        __Marshaller_greet_ProductModel);

    static readonly grpc::Method<global::TestDb2.Empty, global::TestDb2.ProductsResponse> __Method_GetProducts = new grpc::Method<global::TestDb2.Empty, global::TestDb2.ProductsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProducts",
        __Marshaller_greet_Empty,
        __Marshaller_greet_ProductsResponse);

    static readonly grpc::Method<global::TestDb2.ProductModel, global::TestDb2.Empty> __Method_AddProduct = new grpc::Method<global::TestDb2.ProductModel, global::TestDb2.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddProduct",
        __Marshaller_greet_ProductModel,
        __Marshaller_greet_Empty);

    static readonly grpc::Method<global::TestDb2.ProductByIdRequest, global::TestDb2.Empty> __Method_BuyProductById = new grpc::Method<global::TestDb2.ProductByIdRequest, global::TestDb2.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BuyProductById",
        __Marshaller_greet_ProductByIdRequest,
        __Marshaller_greet_Empty);

    static readonly grpc::Method<global::TestDb2.ProductByIdRequest, global::TestDb2.Empty> __Method_DeleteProductById = new grpc::Method<global::TestDb2.ProductByIdRequest, global::TestDb2.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProductById",
        __Marshaller_greet_ProductByIdRequest,
        __Marshaller_greet_Empty);

    static readonly grpc::Method<global::TestDb2.NamesRequest, global::TestDb2.NamesModel> __Method_GetNames = new grpc::Method<global::TestDb2.NamesRequest, global::TestDb2.NamesModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNames",
        __Marshaller_greet_NamesRequest,
        __Marshaller_greet_NamesModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TestDb2.ShopReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteShop</summary>
    [grpc::BindServiceMethod(typeof(RemoteShop), "BindService")]
    public abstract partial class RemoteShopBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::TestDb2.ProductModel> GetProductById(global::TestDb2.ProductByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TestDb2.ProductsResponse> GetProducts(global::TestDb2.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TestDb2.Empty> AddProduct(global::TestDb2.ProductModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TestDb2.Empty> BuyProductById(global::TestDb2.ProductByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TestDb2.Empty> DeleteProductById(global::TestDb2.ProductByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TestDb2.NamesModel> GetNames(global::TestDb2.NamesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemoteShopBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProductById, serviceImpl.GetProductById)
          .AddMethod(__Method_GetProducts, serviceImpl.GetProducts)
          .AddMethod(__Method_AddProduct, serviceImpl.AddProduct)
          .AddMethod(__Method_BuyProductById, serviceImpl.BuyProductById)
          .AddMethod(__Method_DeleteProductById, serviceImpl.DeleteProductById)
          .AddMethod(__Method_GetNames, serviceImpl.GetNames).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RemoteShopBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestDb2.ProductByIdRequest, global::TestDb2.ProductModel>(serviceImpl.GetProductById));
      serviceBinder.AddMethod(__Method_GetProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestDb2.Empty, global::TestDb2.ProductsResponse>(serviceImpl.GetProducts));
      serviceBinder.AddMethod(__Method_AddProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestDb2.ProductModel, global::TestDb2.Empty>(serviceImpl.AddProduct));
      serviceBinder.AddMethod(__Method_BuyProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestDb2.ProductByIdRequest, global::TestDb2.Empty>(serviceImpl.BuyProductById));
      serviceBinder.AddMethod(__Method_DeleteProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestDb2.ProductByIdRequest, global::TestDb2.Empty>(serviceImpl.DeleteProductById));
      serviceBinder.AddMethod(__Method_GetNames, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TestDb2.NamesRequest, global::TestDb2.NamesModel>(serviceImpl.GetNames));
    }

  }
}
#endregion
