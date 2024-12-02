using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor_semana13
{
    public class Productor
    {
        private Cola<Usuario> _cola;
        public Productor(Cola<Usuario> cola)
        {
            _cola = cola;
        }

        public void Producir(Usuario item) 
        { 
        _cola.Agregar(item);
        Thread.Sleep(2000);
        }
    }
}
