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

        private void formListaLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnCargarLibros_Click(object sender, EventArgs e)
        {

            Form formCargarLibros = new frmCargarLibros(biblioteca);
            formCargarLibros.Show();
            formCargarLibros.FormClosed += formCargarLibros_FormClosed;
            this.Hide();

        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            Form formListaLibros = new frmListaLibros(biblioteca);
            formListaLibros.Show();
            formListaLibros.FormClosed += formListaLibros_FormClosed;
            this.Hide();
        }

    }


}