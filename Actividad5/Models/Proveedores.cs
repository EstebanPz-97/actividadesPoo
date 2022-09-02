using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class Proveedores:Entity
    {
        public string NameProveedor { get; private set; }
        public List<ProductoProveedor> productoProveedor { get; private set; }
        public Proveedores(string id, string nameproveedor):base(id)
        {
            NameProveedor = nameproveedor;
            productoProveedor=new();
        }
        public void AddProductos(string productoId)
        {
            this.productoProveedor.Add(
                new ProductoProveedor(
                    Guid.NewGuid().ToString(),
                    productoId,
                    this.Id));
        }
    }
}
