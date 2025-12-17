using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Threading.Tasks;

namespace UILookUpDropDownLib.BackendAPI.Grpc.PipelineInterceptors
{
    internal class RpcExceptionInterceptor : Interceptor
    {
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation
            )
        {
            var call = continuation(request, context);
            return new AsyncUnaryCall<TResponse>(
                HandleResponseAsync(call, context),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose);
        }

        async Task<TResponse> HandleResponseAsync<TRequest, TResponse>(
            AsyncUnaryCall<TResponse> call,
            ClientInterceptorContext<TRequest, TResponse> context
            )
            where TResponse : class
            where TRequest : class
        {
            try
            {
                return await call.ResponseAsync.ConfigureAwait(false);
            }
            catch (RpcException ex)
            {
                Console.WriteLine(FormatLog(context.Method.FullName, ex));
            }
            return null;
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            BlockingUnaryCallContinuation<TRequest, TResponse> continuation
            )
        {
            try
            {
                return continuation(request, context);
            }
            catch (RpcException ex)
            {
                Console.WriteLine(FormatLog(context.Method.FullName, ex));
            }
            return null;
        }

        private static string FormatLog(
            string methodName,
            RpcException ex
            )
            => $"gRPC {methodName} " +
            $"failed: {(int)ex.Status.StatusCode} {ex.Status.StatusCode} " +
            $"- {ex.Status.Detail}";
    }
}
