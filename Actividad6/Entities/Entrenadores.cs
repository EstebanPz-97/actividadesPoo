using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Entities
{
    internal class Entrenadores : Entity
    {
      
        public string Especialidad { get; set; }

        public Entrenadores(string id, string especialidad) : base(id)
        {
            Especialidad = especialidad;
        }

    }
}
