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
    public class FormapagoController : Controller
    {

        private readonly FormapagoNegocio _negocio;

        public FormapagoController(sispedidosDbContext db)
        {
            _negocio = new FormapagoNegocio(db);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var formapagos = _negocio.ObtenerTodos();
            var ViewModel = new FormapagoViewModel
            {
                Formapagos = formapagos
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
