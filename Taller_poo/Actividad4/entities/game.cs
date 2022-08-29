using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    internal class game : entity
    {
        public string plataform { get; private set; }
        public game(int id, string name, string plataform) : base(id, name)
        {
            plataform = plataform;
        }
    }
}
