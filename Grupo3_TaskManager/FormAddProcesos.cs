using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3_TaskManager
{
    public partial class FormAddProcesos : Form
    {
        private string SeleccionAlgoritmo;
        public FormAddProcesos(string algoritmo)
        {
            InitializeComponent();
            //Procesos proceso = new Procesos();

            SeleccionAlgoritmo = algoritmo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrioridad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProceso_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddProcesos_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDProceso.Text);
            string nombre = txtNombre.Text;
            int tiempoLlegada = Convert.ToInt32(txtTiempoLlegada.Text);
            int tiempoCpu = Convert.ToInt32(txtTiempoCPU.Text);
            int prioridad = Convert.ToInt32(txtPrioridad.Text);
            string estado = txtEstado.Text;
            bool terminado = (rdbTrue.Checked ? true : false);
            string algoritmo = SeleccionAlgoritmo.ToString();
            int sorteo = 0;

            Procesos procesos = new Procesos(id, nombre, tiempoLlegada, tiempoCpu, prioridad, estado, terminado, algoritmo, sorteo);

            GestorColas.AgregarProceso(procesos);

            ActualizarDataGridView();

            txtIDProceso.Clear();
            txtNombre.Clear();
            txtTiempoLlegada.Clear();
            txtTiempoCPU.Clear();
            txtPrioridad.Clear();

        }

        private void ActualizarDataGridView()
        {
            datagridProcesos.Rows.Clear();
            var procesos = GestorColas.ObtenerColaProcesos().ToList();

            foreach (Procesos proceso in procesos)
            {
                object valorSorteo = proceso.Sorteo.HasValue ? (object)proceso.Sorteo.Value.ToString() : DBNull.Value;
                datagridProcesos.Rows.Add(proceso.Id, proceso.Nombre, proceso.TiempoLlegada, proceso.TiempoCpu, proceso.Prioridad, proceso.Estado, proceso.Terminado, proceso.Algoritmo, valorSorteo);
            }

            datagridProcesos.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDProceso.Clear();
            txtNombre.Clear();
            txtTiempoLlegada.Clear();
            txtTiempoCPU.Clear();
            txtPrioridad.Clear();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormPrincipal frm = new FormPrincipal();
            frm.ShowDialog();
        }
    }
}
