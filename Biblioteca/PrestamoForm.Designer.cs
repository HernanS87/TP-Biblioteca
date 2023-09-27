namespace Biblioteca
{
    partial class frmPrestamo
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
            btnPedirLibro = new Button();
            txtLibro = new TextBox();
            txtDni = new TextBox();
            lblLibro = new Label();
            lblDni = new Label();
            btnDevolverLibro = new Button();
            dtgvPrestamos = new DataGridView();
            Lector = new DataGridViewTextBoxColumn();
            Libro = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // btnPedirLibro
            // 
            btnPedirLibro.Location = new Point(441, 47);
            btnPedirLibro.Name = "btnPedirLibro";
            btnPedirLibro.Size = new Size(103, 23);
            btnPedirLibro.TabIndex = 13;
            btnPedirLibro.Text = "PEDIR LIBRO";
            btnPedirLibro.UseVisualStyleBackColor = true;
            btnPedirLibro.Click += btnPedirLibro_Click;
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(199, 93);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(140, 23);
            txtLibro.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(199, 34);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(140, 23);
            txtDni.TabIndex = 10;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(146, 96);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(34, 15);
            lblLibro.TabIndex = 8;
            lblLibro.Text = "Libro";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(153, 37);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI";
            // 
            // btnDevolverLibro
            // 
            btnDevolverLibro.Location = new Point(441, 83);
            btnDevolverLibro.Name = "btnDevolverLibro";
            btnDevolverLibro.Size = new Size(103, 23);
            btnDevolverLibro.TabIndex = 14;
            btnDevolverLibro.Text = "DEVOLVER LIBRO";
            btnDevolverLibro.UseVisualStyleBackColor = true;
            btnDevolverLibro.Click += btnDevolverLibro_Click;
            // 
            // dtgvPrestamos
            // 
            dtgvPrestamos.BackgroundColor = SystemColors.ButtonFace;
            dtgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { Lector, Libro });
            dtgvPrestamos.Location = new Point(137, 177);
            dtgvPrestamos.Name = "dtgvPrestamos";
            dtgvPrestamos.RowTemplate.Height = 25;
            dtgvPrestamos.Size = new Size(343, 252);
            dtgvPrestamos.TabIndex = 15;
            // 
            // Lector
            // 
            Lector.HeaderText = "Lector DNI";
            Lector.Name = "Lector";
            Lector.Width = 150;
            // 
            // Libro
            // 
            Libro.HeaderText = "Nombre del libro";
            Libro.Name = "Libro";
            Libro.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 145);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 16;
            label1.Text = "PRESTAMOS VIGENTES";
            // 
            // frmPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(594, 499);
            Controls.Add(label1);
            Controls.Add(dtgvPrestamos);
            Controls.Add(btnDevolverLibro);
            Controls.Add(btnPedirLibro);
            Controls.Add(txtLibro);
            Controls.Add(txtDni);
            Controls.Add(lblLibro);
            Controls.Add(lblDni);
            Name = "frmPrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrestamoForm";
            Load += frmPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPedirLibro;
        private TextBox txtLibro;
        private TextBox txtDni;
        private Label lblLibro;
        private Label lblDni;
        private Button btnDevolverLibro;
        private DataGridView dtgvPrestamos;
        private Label label1;
        private DataGridViewTextBoxColumn Lector;
        private DataGridViewTextBoxColumn Libro;
    }
}