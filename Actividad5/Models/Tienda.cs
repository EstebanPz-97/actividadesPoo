using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    public class Tienda:Entity
    {
        public string Name { get; private set; }
        public string Direccion { get; private set; }
        public List <Producto> Productos { get; private set; }

        private Tienda(string id, string name, string direccion):base(id)
        {
            Name = name;
            Direccion = direccion;
            Productos = new ();
        }
        public static Tienda Build(string id,string name, string direccion)
        {
            return new Tienda(id, name, direccion);
        }
        public void AddProducto(Producto productos)
        {
            this.Productos.Add(productos);
        }
    }
}
