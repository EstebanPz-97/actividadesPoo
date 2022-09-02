using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class Tienda:Entity
    {
        public string Name { get; private set; }
        public string Direccion { get; private set; }
        public List <Productos> Productos { get; private set; }

        public Tienda(string id, string name, string direccion):base(id)
        {
            Name = name;
            Direccion = direccion;
            Productos = new ();
        }
        public void AddProducto(Productos productos)
        {
            this.Productos.Add(productos);
        }
    }
}
