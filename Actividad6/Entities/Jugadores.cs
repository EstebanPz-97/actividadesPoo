using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Entities
{
    internal class Jugadores : Entity
    {
        public string Posiciones { get; set; }
        public Jugadores(string id, string posiciones) : base(id)
        {
            Posiciones = posiciones;
        }


    }
}
