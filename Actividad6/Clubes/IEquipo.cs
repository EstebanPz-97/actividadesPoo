using Actividad6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Clubes
{
    internal interface IEquipo<T> where T : Entity
    {
        public void Inscribir(T obj);
    }
}
