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
            btnMostrarLibros = new Button();
            SuspendLayout();
            // 
            // btnCargarLibros
            // 
            btnCargarLibros.Location = new Point(238, 116);
            btnCargarLibros.Name = "btnCargarLibros";
            btnCargarLibros.Size = new Size(114, 23);
            btnCargarLibros.TabIndex = 0;
            btnCargarLibros.Text = "Cargar Libro";
            btnCargarLibros.UseVisualStyleBackColor = true;
            btnCargarLibros.Click += btnCargarLibros_Click;
            // 
            // btnMostrarLibros
            // 
            btnMostrarLibros.Location = new Point(238, 178);
            btnMostrarLibros.Name = "btnMostrarLibros";
            btnMostrarLibros.Size = new Size(114, 23);
            btnMostrarLibros.TabIndex = 1;
            btnMostrarLibros.Text = "Mostrar Libros";
            btnMostrarLibros.UseVisualStyleBackColor = true;
            btnMostrarLibros.Click += btnMostrarLibros_Click;
            // 
            // frmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(571, 348);
            Controls.Add(btnMostrarLibros);
            Controls.Add(btnCargarLibros);
            Name = "frmBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIBLIOTECA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarLibros;
        private Button btnMostrarLibros;
    }
}