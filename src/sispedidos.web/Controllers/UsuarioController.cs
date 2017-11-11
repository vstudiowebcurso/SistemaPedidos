using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sispedidos.Negocio;
using sispedidos.Data;
using sispedidos.web.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace sispedidos.web.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly UsuarioNegocio _negocio;

        public UsuarioController(sispedidosDbContext db)
        {
            _negocio = new UsuarioNegocio(db);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var usuarios = _negocio.ObtenerTodos();
            var ViewModel = new UsuarioViewModel
            {
                Usuarios = usuarios
            };
            return View(ViewModel);
        }
    }
}
