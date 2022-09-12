using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    public class Proveedores : Entity
    {
        public string NameProveedor { get; private set; }
        public List<ProductoProveedor> productoProveedor { get; private set; }
        private Proveedores(string id, string nameproveedor) : base(id)
        {
            NameProveedor = nameproveedor;
            productoProveedor = new();
        }
        public static Proveedores Build(string id, string nameproveedor)
        {
            return new Proveedores(id, nameproveedor);
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
