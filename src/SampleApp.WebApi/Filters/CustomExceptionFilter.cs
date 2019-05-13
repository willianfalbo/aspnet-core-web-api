using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleApp.Domain;
using SampleApp.WebApi.Models;

namespace SampleApp.WebApi.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            //bool isAjaxCall = context.HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest";

            //if (isAjaxCall)
            //{
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = 500;
                //var message = context.Exception is DomainException ? context.Exception.Message : "An error ocorred";
                var message = string.IsNullOrEmpty(context?.Exception?.Message) ? "An error ocorred" : context.Exception.Message;
                context.Result = new JsonResult(new ResultModel<object>(new { message = message }));
                context.ExceptionHandled = true;
            //}

            base.OnException(context);
        }
    }
}