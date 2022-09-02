
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    internal class console : entity
    {
        public string capacity { get; private set; }
        public int price { get; private set; }
        public console(int id,string name, string capacity, int price) : base(id,name)
        {
            this.capacity = capacity;
            this.price = price;
        }
    }
}
