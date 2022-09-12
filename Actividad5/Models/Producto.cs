using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    public class Producto : Entity
    {
        public string Name { get; private set; }
        public Tienda Tienda { get; private set; }
        public List<ProductoProveedor> ProductoProveedor { get; private set; }

        private Producto(string id, string name, Tienda tienda) : base(id)
        {
            Name = name;
            Tienda = tienda;
            ProductoProveedor = new();
        }
        public static Producto Build(string id, string name, Tienda tienda)
        {
            return new Producto(id,name,tienda);
        }
        public void AddProvedor(string proveedorId)
        {
            this.ProductoProveedor.Add(
                new ProductoProveedor(
                    id: Guid.NewGuid().ToString(),
                    productoid:this.Id,
                    proveedorid:proveedorId));
        }

       
    }
}
