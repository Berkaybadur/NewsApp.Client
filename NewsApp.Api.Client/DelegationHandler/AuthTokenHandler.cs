using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NewsApp.Api.Client.DelegationHandler
{
    public class AuthTokenHandler : DelegatingHandler
    {
        private const string TOKEN = "Authorization";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthTokenHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var currentContext = _httpContextAccessor.HttpContext;
            // var token = await currentContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
            var JWToken = currentContext.Session.ToString()/*.GetString("JWToken")*/;
            var token = JWToken;
            if (!request.Headers.Contains(TOKEN) && string.IsNullOrEmpty(token))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Missing auth token.")
                };
            }
            else if (!request.Headers.Contains(TOKEN) && !string.IsNullOrEmpty(token))
            {
                request.Headers.Add(TOKEN, $"Bearer {token}");
            }

            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }

}
