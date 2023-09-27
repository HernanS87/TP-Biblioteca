namespace Biblioteca
{
    partial class frmCargarLibros
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
            lblNombre = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            btnAgregar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(136, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(136, 97);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(136, 142);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(50, 15);
            lblEditorial.TabIndex = 2;
            lblEditorial.Text = "Editorial";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(219, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(219, 97);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(140, 23);
            txtAutor.TabIndex = 4;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(219, 142);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(140, 23);
            txtEditorial.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(439, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(439, 142);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmCargarLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(572, 221);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtNombre);
            Controls.Add(lblEditorial);
            Controls.Add(lblAutor);
            Controls.Add(lblNombre);
            Name = "frmCargarLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargarLibrosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblAutor;
        private Label lblEditorial;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private Button btnAgregar;
        private Button btnVolver;
    }
}