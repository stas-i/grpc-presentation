// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: grpc_sample_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace GrpcSample.Contracts.Services {
  /// <summary>
  /// Test gRPC service.
  /// </summary>
  public static partial class GrpcSampleService
  {
    static readonly string __ServiceName = "grpcsample.GrpcSampleService";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Services.HelleWorldResponse> __Marshaller_HelleWorldResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Services.HelleWorldResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Messages.GetLinesRequest> __Marshaller_GetLinesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Messages.GetLinesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Messages.Line> __Marshaller_Line = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Messages.Line.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Messages.NumberMessage> __Marshaller_NumberMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Messages.NumberMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Messages.SumResponse> __Marshaller_SumResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Messages.SumResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Messages.MultiplyRequest> __Marshaller_MultiplyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Messages.MultiplyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcSample.Contracts.Messages.MultiplyResponse> __Marshaller_MultiplyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcSample.Contracts.Messages.MultiplyResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcSample.Contracts.Services.HelleWorldResponse> __Method_GetHelloWorld = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::GrpcSample.Contracts.Services.HelleWorldResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetHelloWorld",
        __Marshaller_Empty,
        __Marshaller_HelleWorldResponse);

    static readonly grpc::Method<global::GrpcSample.Contracts.Messages.GetLinesRequest, global::GrpcSample.Contracts.Messages.Line> __Method_GetLines = new grpc::Method<global::GrpcSample.Contracts.Messages.GetLinesRequest, global::GrpcSample.Contracts.Messages.Line>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetLines",
        __Marshaller_GetLinesRequest,
        __Marshaller_Line);

    static readonly grpc::Method<global::GrpcSample.Contracts.Messages.NumberMessage, global::GrpcSample.Contracts.Messages.SumResponse> __Method_Sum = new grpc::Method<global::GrpcSample.Contracts.Messages.NumberMessage, global::GrpcSample.Contracts.Messages.SumResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "Sum",
        __Marshaller_NumberMessage,
        __Marshaller_SumResponse);

    static readonly grpc::Method<global::GrpcSample.Contracts.Messages.MultiplyRequest, global::GrpcSample.Contracts.Messages.MultiplyResponse> __Method_Multiply = new grpc::Method<global::GrpcSample.Contracts.Messages.MultiplyRequest, global::GrpcSample.Contracts.Messages.MultiplyResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Multiply",
        __Marshaller_MultiplyRequest,
        __Marshaller_MultiplyResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcSample.Contracts.Services.GrpcSampleServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GrpcSampleService</summary>
    public abstract partial class GrpcSampleServiceBase
    {
      /// <summary>
      /// A simple RPC.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcSample.Contracts.Services.HelleWorldResponse> GetHelloWorld(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Protocol Buffers are not designed to handle large messages.
      /// As a general rule of thumb, if you are dealing in messages larger than a megabyte each,
      /// it may be time to consider an alternate strategy. 
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task GetLines(global::GrpcSample.Contracts.Messages.GetLinesRequest request, grpc::IServerStreamWriter<global::GrpcSample.Contracts.Messages.Line> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A client-to-server streaming RPC.
      ///
      /// Accepts a stream of numbers and return sum of them.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcSample.Contracts.Messages.SumResponse> Sum(grpc::IAsyncStreamReader<global::GrpcSample.Contracts.Messages.NumberMessage> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A Bidirectional streaming RPC.
      ///
      /// Accepts a stream of Numbers and return stream of multiply responses.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Multiply(grpc::IAsyncStreamReader<global::GrpcSample.Contracts.Messages.MultiplyRequest> requestStream, grpc::IServerStreamWriter<global::GrpcSample.Contracts.Messages.MultiplyResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GrpcSampleService</summary>
    public partial class GrpcSampleServiceClient : grpc::ClientBase<GrpcSampleServiceClient>
    {
      /// <summary>Creates a new client for GrpcSampleService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GrpcSampleServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GrpcSampleService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GrpcSampleServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GrpcSampleServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GrpcSampleServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// A simple RPC.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcSample.Contracts.Services.HelleWorldResponse GetHelloWorld(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetHelloWorld(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A simple RPC.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcSample.Contracts.Services.HelleWorldResponse GetHelloWorld(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetHelloWorld, null, options, request);
      }
      /// <summary>
      /// A simple RPC.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcSample.Contracts.Services.HelleWorldResponse> GetHelloWorldAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetHelloWorldAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A simple RPC.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcSample.Contracts.Services.HelleWorldResponse> GetHelloWorldAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetHelloWorld, null, options, request);
      }
      /// <summary>
      /// Protocol Buffers are not designed to handle large messages.
      /// As a general rule of thumb, if you are dealing in messages larger than a megabyte each,
      /// it may be time to consider an alternate strategy. 
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GrpcSample.Contracts.Messages.Line> GetLines(global::GrpcSample.Contracts.Messages.GetLinesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLines(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Protocol Buffers are not designed to handle large messages.
      /// As a general rule of thumb, if you are dealing in messages larger than a megabyte each,
      /// it may be time to consider an alternate strategy. 
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GrpcSample.Contracts.Messages.Line> GetLines(global::GrpcSample.Contracts.Messages.GetLinesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetLines, null, options, request);
      }
      /// <summary>
      /// A client-to-server streaming RPC.
      ///
      /// Accepts a stream of numbers and return sum of them.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::GrpcSample.Contracts.Messages.NumberMessage, global::GrpcSample.Contracts.Messages.SumResponse> Sum(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Sum(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A client-to-server streaming RPC.
      ///
      /// Accepts a stream of numbers and return sum of them.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::GrpcSample.Contracts.Messages.NumberMessage, global::GrpcSample.Contracts.Messages.SumResponse> Sum(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_Sum, null, options);
      }
      /// <summary>
      /// A Bidirectional streaming RPC.
      ///
      /// Accepts a stream of Numbers and return stream of multiply responses.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcSample.Contracts.Messages.MultiplyRequest, global::GrpcSample.Contracts.Messages.MultiplyResponse> Multiply(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Multiply(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A Bidirectional streaming RPC.
      ///
      /// Accepts a stream of Numbers and return stream of multiply responses.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcSample.Contracts.Messages.MultiplyRequest, global::GrpcSample.Contracts.Messages.MultiplyResponse> Multiply(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Multiply, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GrpcSampleServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GrpcSampleServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GrpcSampleServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetHelloWorld, serviceImpl.GetHelloWorld)
          .AddMethod(__Method_GetLines, serviceImpl.GetLines)
          .AddMethod(__Method_Sum, serviceImpl.Sum)
          .AddMethod(__Method_Multiply, serviceImpl.Multiply).Build();
    }

  }
}
#endregion
