using Microsoft.AspNetCore.Diagnostics;
using NLayer.BLL.Exceptions;
using NLayer.Core.DTOs.ApiResponseDTOs;
using System.Text.Json;

namespace NLayer.API.MiddleWares
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    IExceptionHandlerFeature exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();
                    int statuscode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _=> 500
                    };
                    context.Response.StatusCode = statuscode;
                    var response = CustomResponseDto<NoContentDTO>.Fail(statuscode, exceptionFeature.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
