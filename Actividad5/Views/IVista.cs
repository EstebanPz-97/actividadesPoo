using Actividad5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Views
{
    public interface IVista<T> where T : Entity
    {
        public void Render(T obj);
    }
}
