// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: health.proto
// Original file comments:
// Copyright 2015, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Grpc.Health.V1 {
  public static class Health
  {
    static readonly string __ServiceName = "grpc.health.v1.Health";

    static readonly Marshaller<global::Grpc.Health.V1.HealthCheckRequest> __Marshaller_HealthCheckRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Health.V1.HealthCheckRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Grpc.Health.V1.HealthCheckResponse> __Marshaller_HealthCheckResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Grpc.Health.V1.HealthCheckResponse.Parser.ParseFrom);

    static readonly Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse> __Method_Check = new Method<global::Grpc.Health.V1.HealthCheckRequest, global::Grpc.Health.V1.HealthCheckResponse>(
        MethodType.Unary,
        __ServiceName,
        "Check",
        __Marshaller_HealthCheckRequest,
        __Marshaller_HealthCheckResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Health.V1.HealthReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Health</summary>
    public abstract class HealthBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Grpc.Health.V1.HealthCheckResponse> Check(global::Grpc.Health.V1.HealthCheckRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Health</summary>
    public class HealthClient : ClientBase<HealthClient>
    {
      /// <summary>Creates a new client for Health</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HealthClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Health that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HealthClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HealthClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HealthClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Grpc.Health.V1.HealthCheckResponse Check(global::Grpc.Health.V1.HealthCheckRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Check(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Grpc.Health.V1.HealthCheckResponse Check(global::Grpc.Health.V1.HealthCheckRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Check, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Grpc.Health.V1.HealthCheckResponse> CheckAsync(global::Grpc.Health.V1.HealthCheckRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CheckAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Grpc.Health.V1.HealthCheckResponse> CheckAsync(global::Grpc.Health.V1.HealthCheckRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Check, null, options, request);
      }
      protected override HealthClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HealthClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(HealthBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Check, serviceImpl.Check).Build();
    }

  }
}
#endregion
