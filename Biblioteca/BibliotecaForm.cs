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

        private void formAltaLectores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void formListaLectores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void formPrestamos_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnListarLibros_Click(object sender, EventArgs e)
        {
            Form formListaLibros = new frmListaLibros(biblioteca);
            formListaLibros.Show();
            formListaLibros.FormClosed += formListaLibros_FormClosed;
            this.Hide();
        }

        private void btnAltaLector_Click(object sender, EventArgs e)
        {
            Form formAltaLectores = new frmAltaLectores(biblioteca);
            formAltaLectores.Show();
            formAltaLectores.FormClosed += formAltaLectores_FormClosed;
            this.Hide();
        }

        private void btnListarLectores_Click(object sender, EventArgs e)
        {
            Form formListaLectores = new frmListaLectores(biblioteca);
            formListaLectores.Show();
            formListaLectores.FormClosed += formListaLectores_FormClosed;
            this.Hide();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            Form formPrestamos = new frmPrestamo(biblioteca);
            formPrestamos.Show();
            formPrestamos.FormClosed += formPrestamos_FormClosed;
            this.Hide();
        }
    }


}