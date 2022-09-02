using ConsoleApp2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fabrica
{
    internal class Factory : Ifactory
    {
        public entity BuildGame(int id, string name, string plataform)
        {
            return new game (id , name, plataform);
        }

        public entity BulidConsole(int id, string name, string capacity, int price)
        {
            return new console (id, name, capacity, price);
        }
    }
}
