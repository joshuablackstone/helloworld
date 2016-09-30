using System;
using System.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace HelloWorld.Api
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class CustomCorsAttribute : Attribute, ICorsPolicyProvider
    {
        private readonly CorsPolicy _policy;
        private readonly string OriginAllowed = "http://localhost:52653";

        public CustomCorsAttribute()
        {
            // Create a CORS policy.
            _policy = new CorsPolicy
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true,
                AllowAnyOrigin = false,
                ExposedHeaders = { "Content-Disposition" }
            };

            _policy.Origins.Add(OriginAllowed);
        }

        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_policy);
        }
    }
}