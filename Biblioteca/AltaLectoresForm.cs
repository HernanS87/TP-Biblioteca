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
    public partial class frmAltaLectores : Form
    {
        public Biblioteca biblioteca;
        public frmAltaLectores(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text.Trim();
            String apellido = txtApellido.Text.Trim();
            String dni = txtDNI.Text.Trim();

            bool status = biblioteca.altaLector(nombre, apellido, dni);
            if (status)
            {
                MessageBox.Show("Se cargó el lector correctamente", "LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ups! Este lector ya existe", "LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
