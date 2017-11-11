using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web
{
    public class PruebaFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("Prueba", new string[] { "se agrego cabecera" });
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
