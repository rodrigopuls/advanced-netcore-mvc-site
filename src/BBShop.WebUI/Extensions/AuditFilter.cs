using KissLog;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BBShop.App.Extensions
{
    public class AuditFilter : IActionFilter
    {
        private readonly ILogger _logger;

        public AuditFilter(ILogger logger)
        {
            _logger = logger;
        }

        // OnActionExecuting é chamado antes que o método de ação seja chamado
        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        // OnActionExecuted é chamado após o método de ação retornar
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                //var message = $"{context.HttpContext.User.Identity.Name} - Acessou: {context.HttpContext.Request.GetDisplayUrl()}";

                //_logger.Info(message);
            }
        }


    }
}
