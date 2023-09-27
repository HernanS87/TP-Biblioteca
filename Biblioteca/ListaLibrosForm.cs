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
    public partial class frmListaLibros : Form
    {
        public Biblioteca biblioteca;

        public frmListaLibros(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void ListaLibrosForm_Load(object sender, EventArgs e)
        {
            List<Libro> lista = biblioteca.getLibros();

            dtgvLibros.RowHeadersVisible = false;

            foreach (Libro libro in lista)
            {
                int fila = dtgvLibros.Rows.Add();

                dtgvLibros.Rows[fila].Cells[0].Value = libro.Nombre;
                dtgvLibros.Rows[fila].Cells[1].Value = libro.Autor;
                dtgvLibros.Rows[fila].Cells[2].Value = libro.Editorial;
            }
        }
    }
}
