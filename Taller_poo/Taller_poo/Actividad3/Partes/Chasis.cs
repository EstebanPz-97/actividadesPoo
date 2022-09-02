using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Hardwares
{
    internal class Chasis: Parte
    {
        public override void ConexionElectrica()
        {
            Console.WriteLine("conecte a 5v");
        }
    }
}
