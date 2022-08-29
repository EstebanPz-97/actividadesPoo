using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Hardwares
{
    internal abstract class Hardware
    {
        public void Conectar()
        {
            Console.WriteLine("conectar a la placa");

        }
        public abstract void ConexionElectrica();
    }
}
