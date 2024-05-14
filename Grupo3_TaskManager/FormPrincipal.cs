namespace Grupo3_TaskManager
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProcesos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAddProcesos frmProcesos = new FormAddProcesos();
            frmProcesos.ShowDialog();

            this.Show();
        }

        private void btnListaEjecucion_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormListaEjecucion frmListaEjec = new FormListaEjecucion();
            frmListaEjec.ShowDialog();

            this.Show();
        }

        private void btnConfigSO_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormConfigSO frmConfigSO = new FormConfigSO();
            frmConfigSO.ShowDialog();

            this.Show();
        }

        private void btnEmularTask_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormEmulador frmEmulador = new FormEmulador();
            frmEmulador.ShowDialog();

            this.Show();
        }
    }
}
