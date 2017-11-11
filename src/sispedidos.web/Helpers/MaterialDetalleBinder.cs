using Microsoft.AspNetCore.Mvc.ModelBinding;
using sispedidos.Data;
using sispedidos.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Helpers
{
    public class MaterialDetalleBinder : IModelBinder
    {
        private sispedidosDbContext _db;

        public MaterialDetalleBinder(sispedidosDbContext db)
        {
            _db = db;
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if(bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.BinderModelName;

            if(string.IsNullOrEmpty(modelName))
            {
                modelName = "Id";
            }

            var valueResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            var value = valueResult.FirstValue;

            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }

            int id = 0;
            if(!int.TryParse(value, out id))
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "El Id del Producto debe ser entero");
                return Task.CompletedTask;
            }

            var material = _db.Materiales.FirstOrDefault(m => m.Id == id);
            var viewModel = new MaterialDetalleViewModel();

            if (material != null)
            {
                viewModel.Id = material.Id;
                viewModel.CodigoAuxiliar = material.CodigoAuxiliar;
                viewModel.Nombre = material.Nombre;
                viewModel.PrecioUnitario = material.PrecioUnitario;
                viewModel.Unidad = material.Unidad;
            }

            bindingContext.Result = ModelBindingResult.Success(viewModel);
            return Task.CompletedTask;

        }
    }
}
