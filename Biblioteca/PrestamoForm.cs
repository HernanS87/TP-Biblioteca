using System;
using System.Collections;
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
    public partial class frmPrestamo : Form
    {
        public Biblioteca biblioteca;
        private List<Prestamo> prestamos = new List<Prestamo>();

        public frmPrestamo(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void CargarTabla()
        {
            dtgvPrestamos.Rows.Clear();

            foreach (Prestamo p in prestamos)
            {
                int fila = dtgvPrestamos.Rows.Add();

                dtgvPrestamos.Rows[fila].Cells[0].Value = p.LectorDni;
                dtgvPrestamos.Rows[fila].Cells[1].Value = p.LibroNombre;
            }
        }

        private void btnPedirLibro_Click(object sender, EventArgs e)
        {
            Libro libro = biblioteca.buscarLibro(txtLibro.Text);
            Lector lector = biblioteca.buscarLector(txtDni.Text);
            if (libro != null && lector != null)
            {
                lector.Libros.Add(libro);
                biblioteca.eliminarLibro(libro.getTitulo());
                prestamos.Add(new Prestamo(lector.Dni, libro.getTitulo()));
                CargarTabla();
                MessageBox.Show("Se realizó el prestamo correctamente", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ups! no se pudo realizar el prestamo", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {

            List<Lector> lectores = biblioteca.getLectores();

            foreach (Lector lector in lectores)
            {
                foreach (Libro libro in lector.Libros)
                {
                    prestamos.Add(new Prestamo(lector.Dni, libro.getTitulo()));
                }
            }

            dtgvPrestamos.RowHeadersVisible = false;
            CargarTabla();

        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            Lector lector = biblioteca.buscarLector(txtDni.Text);
            if (lector != null)
            {
                Libro libro = lector.buscarLibro(txtLibro.Text);
                if (libro != null)
                {

                    biblioteca.agregarLibro(libro.Nombre, libro.Autor, libro.Editorial);
                    lector.eliminarLibro(libro.Nombre);
                    prestamos.RemoveAll(prestamo => prestamo.LibroNombre == libro.Nombre);
                    CargarTabla();
                    MessageBox.Show("Se devolvió libro correctamente", "DEVOLUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ups! libro incorrecto", "DEVOLUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ups! lector incorrecto", "DEVOLUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
