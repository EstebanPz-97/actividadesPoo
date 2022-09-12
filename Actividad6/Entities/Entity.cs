using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Entities
{
    internal abstract class Entity
    {
        public string Id { get; set; }

        protected Entity (string id)
        {
            Id = id;
        }
    }
}
