using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor_semana13.Proyecto_Recervaciones
{
    public class ProductorReservas
    {
        private ColaReservas<UsuarioReservas> _colaReservas;
        public ProductorReservas(ColaReservas<UsuarioReservas> colaReservas)
        {
            _colaReservas = colaReservas;
        }

        public void Producir(UsuarioReservas item)
        {
            _colaReservas.Agregar(item);
            Thread.Sleep(2000);
        }
    }
}
