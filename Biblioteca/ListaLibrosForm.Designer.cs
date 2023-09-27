namespace Biblioteca
{
    partial class frmListaLibros
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
            dtgvLibros = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvLibros).BeginInit();
            SuspendLayout();
            // 
            // dtgvLibros
            // 
            dtgvLibros.BackgroundColor = SystemColors.ButtonFace;
            dtgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLibros.Columns.AddRange(new DataGridViewColumn[] { Titulo, Autor, Editorial });
            dtgvLibros.Location = new Point(56, 71);
            dtgvLibros.Name = "dtgvLibros";
            dtgvLibros.RowTemplate.Height = 25;
            dtgvLibros.Size = new Size(493, 252);
            dtgvLibros.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            Titulo.Width = 150;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.Width = 150;
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
            Editorial.Width = 150;
            // 
            // frmListaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(596, 384);
            Controls.Add(dtgvLibros);
            Name = "frmListaLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaLibrosForm";
            Load += ListaLibrosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvLibros;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editorial;
    }
}