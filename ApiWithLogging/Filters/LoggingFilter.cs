using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiWithLogging.Filters;

public class LoggingFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        var action = ((ControllerActionDescriptor)context.ActionDescriptor).ActionName;
        var controller = ((ControllerBase)context.Controller).ControllerContext.ActionDescriptor.ControllerName;

        Console.WriteLine($"Called before {action} {controller}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        var action = ((ControllerActionDescriptor)context.ActionDescriptor).ActionName;
        var controller = ((ControllerBase)context.Controller).ControllerContext.ActionDescriptor.ControllerName;

        Console.WriteLine($"Called after {action} {controller}");
    }
}
