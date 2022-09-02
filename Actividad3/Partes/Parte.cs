using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Hardwares
{
    internal abstract class Parte
    {
        public void Conectar()
        {
            Console.WriteLine("conectar a la    ");

        }
        public abstract void ConexionElectrica();
    }
}
