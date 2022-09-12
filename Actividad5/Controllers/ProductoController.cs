using Actividad5.Models;
using Actividad5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Controllers
{
    public class ProductoController
    {
        private IVista<Producto> vista;

        public ProductoController(IVista<Producto> vista)
        {
            this.vista = vista;
        }

        public void Crear(string id, string name, Tienda tienda)
        {
            Producto producto;

            producto = Producto.Build(id, name, tienda);

            this.vista.Render(producto);
        }

    }
}
