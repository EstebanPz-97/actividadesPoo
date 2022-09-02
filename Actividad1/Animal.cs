using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal:Entidad
    {
        public string Tipo { get; private set; }

        public Animal(string name , string tipo):base(name)
        {
            Tipo = tipo;
        }
    }
}
