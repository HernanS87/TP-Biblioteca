namespace Biblioteca
{
    partial class frmBiblioteca
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
            btnCargarLibros = new Button();
            btnListarLibros = new Button();
            btnAltaLector = new Button();
            btnListarLectores = new Button();
            btnPrestamo = new Button();
            SuspendLayout();
            // 
            // btnCargarLibros
            // 
            btnCargarLibros.Location = new Point(58, 81);
            btnCargarLibros.Name = "btnCargarLibros";
            btnCargarLibros.Size = new Size(114, 23);
            btnCargarLibros.TabIndex = 0;
            btnCargarLibros.Text = "Cargar Libro";
            btnCargarLibros.UseVisualStyleBackColor = true;
            btnCargarLibros.Click += btnCargarLibros_Click;
            // 
            // btnListarLibros
            // 
            btnListarLibros.Location = new Point(58, 157);
            btnListarLibros.Name = "btnListarLibros";
            btnListarLibros.Size = new Size(114, 23);
            btnListarLibros.TabIndex = 1;
            btnListarLibros.Text = "Libros";
            btnListarLibros.UseVisualStyleBackColor = true;
            btnListarLibros.Click += btnListarLibros_Click;
            // 
            // btnAltaLector
            // 
            btnAltaLector.Location = new Point(215, 81);
            btnAltaLector.Name = "btnAltaLector";
            btnAltaLector.Size = new Size(114, 23);
            btnAltaLector.TabIndex = 2;
            btnAltaLector.Text = "Alta Lector";
            btnAltaLector.UseVisualStyleBackColor = true;
            btnAltaLector.Click += btnAltaLector_Click;
            // 
            // btnListarLectores
            // 
            btnListarLectores.Location = new Point(215, 157);
            btnListarLectores.Name = "btnListarLectores";
            btnListarLectores.Size = new Size(114, 23);
            btnListarLectores.TabIndex = 3;
            btnListarLectores.Text = "Lectores";
            btnListarLectores.UseVisualStyleBackColor = true;
            btnListarLectores.Click += btnListarLectores_Click;
            // 
            // btnPrestamo
            // 
            btnPrestamo.Location = new Point(388, 81);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new Size(114, 23);
            btnPrestamo.TabIndex = 4;
            btnPrestamo.Text = "Prestamo";
            btnPrestamo.UseVisualStyleBackColor = true;
            btnPrestamo.Click += btnPrestamo_Click;
            // 
            // frmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(571, 348);
            Controls.Add(btnPrestamo);
            Controls.Add(btnListarLectores);
            Controls.Add(btnAltaLector);
            Controls.Add(btnListarLibros);
            Controls.Add(btnCargarLibros);
            Name = "frmBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIBLIOTECA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarLibros;
        private Button btnListarLibros;
        private Button btnAltaLector;
        private Button btnListarLectores;
        private Button btnPrestamo;
    }
}