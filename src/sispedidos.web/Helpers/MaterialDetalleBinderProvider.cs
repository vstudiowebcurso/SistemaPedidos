﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using sispedidos.Entidades;
using sispedidos.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sispedidos.web.Helpers
{
    public class MaterialDetalleBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if(context.Metadata.ModelType == typeof(MaterialDetalleViewModel))
            {
                return new BinderTypeModelBinder(typeof(MaterialDetalleBinder));
            }

            return null;

        }
    }
}
