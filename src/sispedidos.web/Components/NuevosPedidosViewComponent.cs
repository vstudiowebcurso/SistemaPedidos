using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sispedidos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Components
{
    public class NuevosPedidosViewComponent : ViewComponent
    {
        private sispedidosDbContext _db;
        public NuevosPedidosViewComponent(sispedidosDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pedidos = await _db.Docus.ToListAsync();

            return View("NuevosPedidosTag", pedidos);
        }
    }
}