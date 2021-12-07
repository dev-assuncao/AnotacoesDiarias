using AspNetCoreIdentity.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;


namespace AspNetCoreIdentity.Configuration
{
    public static class IdentityConfig
    {

        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeExcluir", configurePolicy: policy => policy.RequireClaim("PodeExcluir"));

                options.AddPolicy("PodeLer", configurePolicy: policy => policy.Requirements.Add(new PermissaoNecessaria(permissao: "PodeLer")));
                options.AddPolicy("PodeEscrever", configurePolicy: policy => policy.Requirements.Add(new PermissaoNecessaria(permissao: "PodeEscrever")));

            });

            return services;
        }
    }
}
