using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using UILookUpDropDownLib.BackendAPI.Configuration;
using UILookUpDropDownLib.BackendAPI.Grpc.PipelineInterceptors;

namespace UILookUpDropDownLib.BackendAPI.Grpc.Infrastructure
{
    public class GrpcConnectionManager : IDisposable
    {
        private readonly GrpcChannel _channel;

        private readonly CallInvoker _invoker;

        public GrpcConnectionManager(IOptions<GrpcSettings> options)
        {
            var address = options.Value.Address;

            var httpHandler = new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler());
            /*var httpHandler = new WinHttpHandler
            {
                EnableMultipleHttp2Connections = true
            };*/

            /*var httpClient = new HttpClient(httpHandler)
            {
                Timeout = TimeSpan.FromMinutes(5)
            };*/

            _channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions
            {
                HttpHandler = httpHandler,
                //HttpClient = httpClient,
                MaxReceiveMessageSize = 1024 * 1024 * 1024, // 1GB
                MaxSendMessageSize = 1024 * 1024 * 1024
            });

            _invoker = _channel.Intercept(new RpcExceptionInterceptor());
        }

        public CallInvoker GetInvoker() => _invoker;

        public void Dispose()
        {
            _channel?.Dispose();
        }
    }
}
