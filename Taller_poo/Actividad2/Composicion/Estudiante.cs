using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo2.Composicion
{
    internal class Estudiante
    {
        private Escuela Escuela;

        public Estudiante()
        {
            this.Escuela = new Escuela();
        }
    }
}
