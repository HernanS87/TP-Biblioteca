using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmCargarLibros : Form
    {
        private Biblioteca biblioteca;
        public frmCargarLibros(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text.Trim();
            String autor = txtAutor.Text.Trim();
            String editorial = txtEditorial.Text.Trim();

            bool status = biblioteca.agregarLibro(nombre, autor, editorial);
            if (status)
            {
                MessageBox.Show("Se cargó el libro correctamente", "LIBRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ups! Este libro ya existe", "LIBRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
