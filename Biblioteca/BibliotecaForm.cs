namespace Biblioteca
{
    public partial class frmBiblioteca : Form
    {
        private Biblioteca biblioteca = new Biblioteca();
        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void formCargarLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form formCargarLibros = new frmCargarLibros(biblioteca);
            formCargarLibros.Show();
            formCargarLibros.FormClosed += formCargarLibros_FormClosed;
            this.Hide();

        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            //Mostrar los nombres en un MessageBox
            List<Libro> lista = biblioteca.getLibros();
            string mensaje = "Los libros de la biblioteca son:\n";

            foreach (Libro l in lista)
            {
                mensaje += l.ToString() + "\n";
            }

            MessageBox.Show(mensaje, "Nombres", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}