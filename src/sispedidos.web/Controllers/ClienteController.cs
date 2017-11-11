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
    public class ClienteController : Controller
    {

        private readonly ClienteNegocio _negocio;

        public ClienteController(sispedidosDbContext db)
        {
            _negocio = new ClienteNegocio(db);
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var clientes = _negocio.ObtenerTodos();
            var ViewModel = new ClienteViewModel
            {
                Clientes = clientes
            };
            return View(ViewModel);
        }

        [Route("Cliente/Editar")]
        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Crear()
        {
            return View();
        }

        public IActionResult Detalle(int id)
        {
            return View();
        }

    }
}
