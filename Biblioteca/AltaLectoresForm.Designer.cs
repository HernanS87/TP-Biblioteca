namespace Biblioteca
{
    partial class frmAltaLectores
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
            btnAgregar = new Button();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(404, 144);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(184, 188);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(140, 23);
            txtDNI.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(184, 143);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(140, 23);
            txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 10;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(101, 188);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 9;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(101, 143);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(101, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // frmAltaLectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(580, 304);
            Controls.Add(btnAgregar);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmAltaLectores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaLectoresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
    }
}