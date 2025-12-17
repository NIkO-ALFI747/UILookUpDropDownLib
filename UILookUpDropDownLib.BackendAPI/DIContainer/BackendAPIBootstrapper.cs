using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using UILookUpDropDownLib.Abstractions.BackendAPI.Grpc;
using UILookUpDropDownLib.BackendAPI.Configuration;
using UILookUpDropDownLib.BackendAPI.Grpc.Infrastructure;
using UILookUpDropDownLib.BackendAPI.Grpc.Services;
using UILookUpDropDownLib.BackendAPI.Mappers;

namespace UILookUpDropDownLib.BackendAPI.DIContainer
{
    public static class BackendAPIBootstrapper
    {
        internal static IServiceProvider _serviceProvider;

        private static readonly object _lock = new object();

        public static bool IsInitialized => _serviceProvider != null;

        public static void Initialize(IConfiguration configuration = null)
        {
            if (_serviceProvider != null) return;

            lock (_lock)
            {
                configuration = BuildConfiguration(configuration);
                if (_serviceProvider != null) return;
                var services = new ServiceCollection();
                services.Configure<GrpcSettings>(configuration.GetSection(nameof(GrpcSettings)));
                services.AddAutoMapper(typeof(GrpcMappingProfile));
                services.AddSingleton<GrpcConnectionManager>();
                services.AddTransient<IDbService, GrpcDbService>();
                _serviceProvider = services.BuildServiceProvider();
            }
        }

        private static IConfiguration BuildConfiguration(IConfiguration configuration = null)
        {
            if (configuration != null) return configuration;
            string basePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (string.IsNullOrEmpty(basePath))
                basePath = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);
            return builder.Build();
        }
    }
}
