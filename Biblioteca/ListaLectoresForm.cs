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
    public partial class frmListaLectores : Form
    {
        public Biblioteca biblioteca;
        public frmListaLectores(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void frmListaLectores_Load(object sender, EventArgs e)
        {
            List<Lector> lista = biblioteca.getLectores();

            dtgvLectores.RowHeadersVisible = false;

            foreach (Lector lector in lista)
            {
                int fila = dtgvLectores.Rows.Add();

                dtgvLectores.Rows[fila].Cells[0].Value = lector.Nombre;
                dtgvLectores.Rows[fila].Cells[1].Value = lector.Apellido;
                dtgvLectores.Rows[fila].Cells[2].Value = lector.Dni;
                dtgvLectores.Rows[fila].Cells[3].Value = lector.Libros.Count;
            }
        }
    }
}
