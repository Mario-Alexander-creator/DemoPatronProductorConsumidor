namespace DemoPatronProductorConsumidor_semana13
{
    partial class FrmReservaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            BtnProcesarRecervacion = new Button();
            DGVUsuariosReservas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            BtnCargarReservacion = new Button();
            TxtCorreoReservante = new TextBox();
            label2 = new Label();
            TxtNombreReservante = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuariosReservas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnProcesarRecervacion);
            panel2.Controls.Add(DGVUsuariosReservas);
            panel2.Location = new Point(12, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 245);
            panel2.TabIndex = 3;
            // 
            // BtnProcesarRecervacion
            // 
            BtnProcesarRecervacion.Location = new Point(145, 17);
            BtnProcesarRecervacion.Name = "BtnProcesarRecervacion";
            BtnProcesarRecervacion.Size = new Size(154, 23);
            BtnProcesarRecervacion.TabIndex = 1;
            BtnProcesarRecervacion.Text = "Procesar Recervacion";
            BtnProcesarRecervacion.UseVisualStyleBackColor = true;
            BtnProcesarRecervacion.Click += BtnProcesarRecervacion_Click;
            // 
            // DGVUsuariosReservas
            // 
            DGVUsuariosReservas.AllowUserToAddRows = false;
            DGVUsuariosReservas.AllowUserToDeleteRows = false;
            DGVUsuariosReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuariosReservas.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            DGVUsuariosReservas.Location = new Point(3, 49);
            DGVUsuariosReservas.Name = "DGVUsuariosReservas";
            DGVUsuariosReservas.ReadOnly = true;
            DGVUsuariosReservas.Size = new Size(403, 193);
            DGVUsuariosReservas.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCargarReservacion);
            panel1.Controls.Add(TxtCorreoReservante);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtNombreReservante);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 177);
            panel1.TabIndex = 2;
            // 
            // BtnCargarReservacion
            // 
            BtnCargarReservacion.Location = new Point(145, 139);
            BtnCargarReservacion.Name = "BtnCargarReservacion";
            BtnCargarReservacion.Size = new Size(154, 23);
            BtnCargarReservacion.TabIndex = 4;
            BtnCargarReservacion.Text = "Cargar Reservacion";
            BtnCargarReservacion.UseVisualStyleBackColor = true;
            BtnCargarReservacion.Click += BtnCargarReservacion_Click;
            // 
            // TxtCorreoReservante
            // 
            TxtCorreoReservante.Location = new Point(17, 92);
            TxtCorreoReservante.Name = "TxtCorreoReservante";
            TxtCorreoReservante.Size = new Size(339, 23);
            TxtCorreoReservante.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 2;
            label2.Text = "Correo del Recervante :";
            // 
            // TxtNombreReservante
            // 
            TxtNombreReservante.Location = new Point(17, 33);
            TxtNombreReservante.Name = "TxtNombreReservante";
            TxtNombreReservante.Size = new Size(339, 23);
            TxtNombreReservante.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Reservante :";
            // 
            // FrmReservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmReservaciones";
            Text = "FrmReservaciones";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsuariosReservas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView DGVUsuariosReservas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
        private Panel panel1;
        private TextBox TxtCorreoReservante;
        private Label label2;
        private TextBox TxtNombreReservante;
        private Label label1;
        private Button BtnProcesarRecervacion;
        private Button BtnCargarReservacion;
    }
}