using Microsoft.Extensions.DependencyInjection;
using System;
using UILookUpDropDownLib.Abstractions.BackendAPI.Grpc;

namespace UILookUpDropDownLib.BackendAPI.DIContainer
{
    public static class BackendAPIAccessor
    {
        public static IDbService DbService => GetService<IDbService>();

        private static TService GetService<TService>()
        {
            var provider = BackendAPIBootstrapper._serviceProvider ??
                throw new InvalidOperationException(
                    $"{nameof(BackendAPI)} is not initialized." +
                    $"Call {nameof(BackendAPIBootstrapper)}.{nameof(BackendAPIBootstrapper.Initialize)} first."
                    );
            return provider.GetRequiredService<TService>();
        }
    }
}
