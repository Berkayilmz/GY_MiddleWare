using GY_MiddleWare.Middlewares;
using Microsoft.AspNetCore.Builder;
using System.Runtime.CompilerServices;

namespace GY_MiddleWare.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
