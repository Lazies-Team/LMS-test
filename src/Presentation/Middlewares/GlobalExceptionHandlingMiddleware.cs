using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Presentation.Middlewares
{
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlingMiddleware(RequestDelegate next)
            => _next = next;

        public async Task InvokeAsync(
            HttpContext httpContext,
            [FromServices] ILogger<GlobalExceptionHandlingMiddleware> logger)
        {
            try
            {
                await _next(httpContext);
            }
            catch (ValidationException validationException)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                logger.LogError(validationException, validationException.Message);

                await HandleExceptionAsync(httpContext, validationException.Message);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, exception.Message);

                await HandleExceptionAsync(httpContext, exception.Message);
            }
        }

        private async Task HandleExceptionAsync(
            HttpContext context,
            string message)
        {
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(message);
        }
    }
}
