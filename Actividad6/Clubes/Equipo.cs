using Actividad6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Clubes
{
    internal class Equipo<T> : IEquipo<T> where T : Entity
    {
        private List<T> inscritos { get; set; }

        public Equipo():base()
        {
            inscritos = new List<T>();
        }
        public void Inscribir(T obj)
        {
            obj.Id = "123";
            inscritos.Add(obj);
        }

        
    }
}
