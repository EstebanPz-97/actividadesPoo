using Actividad3.Hardwares;
using Actividad3.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Computadores
{
    internal class Computador
    {
        private IPeriferico Periferico;

        private Hardware RAM;

        private Hardware Procesador;

        private IPeriferico periferico1;

        public Computador(IPeriferico periferico, IPeriferico periferico1)
        {
            Periferico = periferico;

            this.RAM = new Ram();
            this.Procesador = new Procesador();
        }
    }
}
