using Actividad5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Views.Productos
{
    internal class CrearProducto : IVista<Producto>
    {
        public void Render(Producto obj)
        {
            Console.WriteLine($"Se a creado el producto {obj.Name}");
        }
    }
}
