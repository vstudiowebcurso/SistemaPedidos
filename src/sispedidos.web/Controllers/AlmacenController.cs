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
    public class AlmacenController : Controller
    {

        private readonly AlmacenNegocio _negocio;

        public AlmacenController(sispedidosDbContext db)
        {
            _negocio = new AlmacenNegocio(db);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var almacenes = _negocio.ObtenerTodos();
            var ViewModel = new AlmacenViewModel
            {
                Almacenes = almacenes
            };
            return View(ViewModel);
        }

       
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
