using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor_semana13.Proyecto_Recervaciones
{
    public class ConsumidorReservas
    {
        private ColaReservas<UsuarioReservas> _colaReservas;

        public ConsumidorReservas(ColaReservas<UsuarioReservas> colaReservas)
        {
            _colaReservas = colaReservas;
        }

        public UsuarioReservas Consumir()
        {
            UsuarioReservas usuarioReservas = _colaReservas.Extraer();
            Thread.Sleep(5000);
            return usuarioReservas;
        }
    }
}
