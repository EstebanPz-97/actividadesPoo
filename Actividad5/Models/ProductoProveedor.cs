using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Models
{
    internal class ProductoProveedor:Entity
    {
        public string Productoid { get; private set; }
        public string Proveedorid { get; private set; }

        public ProductoProveedor (string id,string productoid, string proveedorid):base(id)
        {
            Productoid = productoid;
            Proveedorid = proveedorid;
        }
    }
}
