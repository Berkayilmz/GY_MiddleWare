using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Threading.Tasks;

namespace GY_MiddleWare.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next=next;
        }

        // Alttaki metodun mutlaka bulunması gerekir.
        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Hello!");
            await _next.Invoke(httpContext);
            Console.WriteLine("Hi!");
        }
    }
}
