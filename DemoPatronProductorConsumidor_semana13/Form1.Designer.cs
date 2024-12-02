namespace DemoPatronProductorConsumidor_semana13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnRegistrar = new Button();
            TxtCorreoElectronico = new TextBox();
            label2 = new Label();
            TxtNombres = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            BtnProcesar = new Button();
            DGVUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TxtCorreoElectronico);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 174);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(427, 139);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 23);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // TxtCorreoElectronico
            // 
            TxtCorreoElectronico.Location = new Point(17, 92);
            TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            TxtCorreoElectronico.Size = new Size(485, 23);
            TxtCorreoElectronico.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Correo electrónico :";
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(17, 33);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(485, 23);
            TxtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres :";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(DGVUsuarios);
            panel2.Location = new Point(12, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 196);
            panel2.TabIndex = 1;
            // 
            // BtnProcesar
            // 
            BtnProcesar.Location = new Point(427, 3);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(75, 23);
            BtnProcesar.TabIndex = 1;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = true;
            BtnProcesar.Click += BtnProcesar_Click_1;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.AllowUserToAddRows = false;
            DGVUsuarios.AllowUserToDeleteRows = false;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            DGVUsuarios.Location = new Point(3, 3);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.ReadOnly = true;
            DGVUsuarios.Size = new Size(403, 193);
            DGVUsuarios.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 393);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostración patrón Productor-Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnRegistrar;
        private TextBox TxtCorreoElectronico;
        private Label label2;
        private TextBox TxtNombres;
        private Label label1;
        private Panel panel2;
        private DataGridView DGVUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
        private Button BtnProcesar;
    }
}
