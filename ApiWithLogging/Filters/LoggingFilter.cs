using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiWithLogging.Filters;

public class LoggingFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        var method = context.HttpContext.Request.Method;
        var path = context.HttpContext.Request.Path;

        // TODO: Please change the code for log output to fit your project.
        Console.WriteLine($"Called before {method} {path}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        var method = context.HttpContext.Request.Method;
        var path = context.HttpContext.Request.Path;

        // TODO: Please change the code for log output to fit your project.
        Console.WriteLine($"Called after {method} {path}");
    }
}
