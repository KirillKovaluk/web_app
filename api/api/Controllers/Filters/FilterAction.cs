using Microsoft.AspNetCore.Mvc.Filters;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Filters
{
    public class FilterAction : IActionFilter
    {
        private readonly IErrorService _errorService;

        public FilterAction(IErrorService errorService)
        {
            _errorService = errorService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_errorService.HasErrors)
            {
                context.Result = new BadRequestObjectResult(_errorService);
                return;
            }
        }
    }
}
