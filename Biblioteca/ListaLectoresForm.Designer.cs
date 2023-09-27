namespace Biblioteca
{
    partial class frmListaLectores
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
            dtgvLectores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Prestamos = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvLectores).BeginInit();
            SuspendLayout();
            // 
            // dtgvLectores
            // 
            dtgvLectores.BackgroundColor = SystemColors.ButtonFace;
            dtgvLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLectores.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, DNI, Prestamos });
            dtgvLectores.Location = new Point(28, 39);
            dtgvLectores.Name = "dtgvLectores";
            dtgvLectores.RowTemplate.Height = 25;
            dtgvLectores.Size = new Size(577, 252);
            dtgvLectores.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.Width = 150;
            // 
            // Prestamos
            // 
            Prestamos.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Prestamos.HeaderText = "Prestamos";
            Prestamos.Name = "Prestamos";
            Prestamos.Width = 87;
            // 
            // button1
            // 
            button1.Location = new Point(28, 344);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 2;
            button1.Text = "Mostrar libros x lector";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmListaLectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(652, 440);
            Controls.Add(button1);
            Controls.Add(dtgvLectores);
            Name = "frmListaLectores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaLectoresForm";
            Load += frmListaLectores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvLectores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvLectores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Prestamos;
        private Button button1;
    }
}