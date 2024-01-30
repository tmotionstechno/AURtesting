using SoapCore;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace AUR.RetailWebService.Infrastructure
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AURMiddleware : IMiddleware
    {
        //private readonly RequestDelegate _next;
        //private readonly Type _serviceType;
        //private readonly string _endpointPath;
        //private readonly MessageEncoder _messageEncoder;
        //private readonly ILogger _logger;

        //public AURMiddleware(RequestDelegate next, Type serviceType, string path, MessageEncoder encoder, ILogger logger)
        //{
        //    _next = next;
        //    _serviceType = serviceType;
        //    _endpointPath = path;
        //    _messageEncoder = encoder;
        //    _logger = logger;
        //}
        public AURMiddleware()
        {
        }
        public async Task InvokeAsync(
         HttpContext context,
         RequestDelegate next)
        {
            string data=("Before request");

            await next(context);

            data = ("After request");
        }
        //public Task Invoke(HttpContext httpContext)
        //{
        //    return _next(httpContext);
        //}
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AURExtensions
    {
        public static IApplicationBuilder UseAURMiddleware<T>(this IApplicationBuilder builder, string path, Binding binding)
        {
            var encoder = binding.CreateBindingElements().Find<MessageEncodingBindingElement>()?.CreateMessageEncoderFactory().Encoder;
            return builder.UseMiddleware<AURMiddleware>(typeof(T), path, encoder);
        }
    }
}
