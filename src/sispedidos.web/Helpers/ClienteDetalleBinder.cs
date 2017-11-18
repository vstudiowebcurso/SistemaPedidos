using Microsoft.AspNetCore.Mvc.ModelBinding;
using sispedidos.Data;
using sispedidos.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Helpers
{
    public class ClienteDetalleBinder : IModelBinder
    {
        private sispedidosDbContext _db;

        public ClienteDetalleBinder(sispedidosDbContext db)
        {
            _db = db;
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.BinderModelName;

            if (string.IsNullOrEmpty(modelName))
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
            if (!int.TryParse(value, out id))
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "El Id del Cliente debe ser entero");
                return Task.CompletedTask;
            }

            var cliente = _db.Clientes.FirstOrDefault(c => c.Id == id);
            var viewModel = new ClienteDetalleViewModel();

            if (cliente != null)
            {
                viewModel.Id = cliente.Id;
                viewModel.NombreCliente = cliente.NombreCliente;
                viewModel.RucCliente = cliente.RucCliente;
                viewModel.Telefono1 = cliente.Telefono1;
                viewModel.Departamento = cliente.Departamento;
                viewModel.Distrito = cliente.Distrito;
                viewModel.Direccion = cliente.Direccion;
                viewModel.Email = cliente.Email;
            }

            bindingContext.Result = ModelBindingResult.Success(viewModel);
            return Task.CompletedTask;
        }
    }
}
