using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sispedidos.Data;
using sispedidos.Negocio;
using sispedidos.web.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace sispedidos.web.Controllers
{

    public class MaterialController : Controller
    {
        private readonly MaterialNegocio _negocio;

        public MaterialController(sispedidosDbContext db)
        {
            _negocio = new MaterialNegocio(db);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var materiales = _negocio.ObtenerTodos();
            var ViewModel = new MaterialViewModel
            {
                Materiales = materiales
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
