using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;

namespace BaseLibrary.Security
{
    public class AntiforgeryTokenMiddleware
    {
        private readonly IAntiforgery _antiforgery;
        private readonly RequestDelegate _next;
        public AntiforgeryTokenMiddleware(RequestDelegate next, IAntiforgery antiforgery)
        {
            _next = next;
            _antiforgery = antiforgery;
        }

        public Task Invoke(HttpContext context)
        {
            string path = context.Request.Path.Value;

            if (context.Request.Headers.ContainsKey("X-XSRF-TOKEN"))
            {
                _antiforgery.ValidateRequestAsync(context);
            }

            if (path.IndexOf("/api/", StringComparison.OrdinalIgnoreCase) != -1)
            {
                var tokens = _antiforgery.GetAndStoreTokens(context);
                context.Response.Cookies.Append("XSRF-TOKEN", tokens.RequestToken, new CookieOptions
                {
                    HttpOnly = false,
                    Secure = true
                });
            }


            return _next(context);  
        }
    }

    
}
