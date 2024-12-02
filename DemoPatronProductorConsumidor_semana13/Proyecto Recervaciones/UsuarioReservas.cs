using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor_semana13.Proyecto_Recervaciones
{
    public class UsuarioReservas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaCreacion { get; set; }

        public UsuarioReservas(int id, string nombre, string correo)
        {
            Id = id;
            Nombre = nombre;
            CorreoElectronico = correo;
            FechaCreacion = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id:{Id}, Nombre:{Nombre}, Correo:{CorreoElectronico}, Fecha:{FechaCreacion}";
        }
    }
}

