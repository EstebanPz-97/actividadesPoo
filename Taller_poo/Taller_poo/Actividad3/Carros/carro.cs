using Actividad3.Hardwares;
using Actividad3.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Computadores
{
    internal class carro
    {
        private Iaccesorio Accesorio;

        private Parte Motor;

        private Parte Chasis;

        private Iaccesorio accesorio1;

        public carro(Iaccesorio accesorio, Iaccesorio accesorio1)
        {
            Accesorio = accesorio;

            this.Chasis = new Chasis();
            this.Motor = new Motor();
        }
    }
}
