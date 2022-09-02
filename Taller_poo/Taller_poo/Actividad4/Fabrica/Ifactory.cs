using ConsoleApp2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Fabrica
{
    internal interface Ifactory
    {
        public entity BuildGame(int id, string name, string plataform);
        public entity BulidConsole (int id, string name, string capacity, int price);


    }
}
