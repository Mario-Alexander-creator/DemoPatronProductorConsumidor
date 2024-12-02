using DemoPatronProductorConsumidor_semana13.Proyecto_Recervaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPatronProductorConsumidor_semana13
{
    public partial class FrmReservaciones : Form
    {
        private int contadorId = 1;
        private ColaReservas<UsuarioReservas> colaUsuarios;
        private ProductorReservas productorReservas;
        private ConsumidorReservas consumidorReservas;
        public FrmReservaciones()
        {
            InitializeComponent();
            colaUsuarios = new ColaReservas<UsuarioReservas>(10);
            productorReservas = new ProductorReservas(colaUsuarios);
            consumidorReservas = new ConsumidorReservas(colaUsuarios);

        }

        private void BtnCargarReservacion_Click(object sender, EventArgs e)
        {
            UsuarioReservas nuevoUsuario = new UsuarioReservas
           (contadorId++, TxtNombreReservante.Text, TxtCorreoReservante.Text);

            ThreadPool.QueueUserWorkItem
                (state =>
                {
                    colaUsuarios.Agregar(nuevoUsuario);
                }
                );
            TxtNombreReservante.Clear();
            TxtCorreoReservante.Clear();
        }

        private void BtnProcesarRecervacion_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuarioReservas);
            hiloConsumidor.Start();
        }

        private void ProcesarUsuarioReservas()
        {
            UsuarioReservas usuarioReservas = colaUsuarios.Extraer();
            AgregarUsuarioReservasADataGrid(usuarioReservas);
        }
        private void AgregarUsuarioReservasADataGrid(UsuarioReservas usuarioReservas)
        {
            if (DGVUsuariosReservas.InvokeRequired)
            {
                DGVUsuariosReservas.Invoke(new Action(() =>
                {
                    DGVUsuariosReservas.Rows.Add
                        (usuarioReservas.Id, usuarioReservas.Nombre, usuarioReservas.CorreoElectronico, usuarioReservas.FechaCreacion);
                })
                );
            }
            else
            {
                DGVUsuariosReservas.Rows.Add
                  (usuarioReservas.Id, usuarioReservas.Nombre, usuarioReservas.CorreoElectronico, usuarioReservas.FechaCreacion);
            }
        }
    }
}