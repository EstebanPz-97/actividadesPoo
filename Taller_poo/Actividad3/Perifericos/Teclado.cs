using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Perifericos
{
    internal class Teclado:IPeriferico
    {
        public void Conectar()
        {
            Console.WriteLine("Se conecto teclado por usb");
        }
    }
}
