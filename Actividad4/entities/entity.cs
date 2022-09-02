using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    internal abstract class entity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        protected entity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
