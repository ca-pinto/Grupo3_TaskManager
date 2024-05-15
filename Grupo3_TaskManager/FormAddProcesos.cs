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
            DataGridViewButtonColumn matar = new DataGridViewButtonColumn();
            matar.HeaderText = "Matar";
            matar.Text = "x";
            matar.Name = "btnMatar";
            matar.UseColumnTextForButtonValue = true;

            datagridProcesos.Columns.Add(matar);

            LlenarDataGridView();
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

        private void LlenarDataGridView()
        {

            foreach (var proceso in GestorColas.ObtenerColaProcesos())
            {
                dataGridView1.Rows.Add(proceso.Id, proceso.Nombre, proceso.TiempoLlegada, proceso.TiempoCpu, proceso.Prioridad, proceso.Estado, proceso.Algoritmo, proceso.Sorteo);
            }
        }
        private void EliminarProcesoPorId(int id)
        {

            var proceso = GestorColas.ObtenerProcesoPorId(id);
            if (proceso != null)
            {
                var listaProcesos = GestorColas.ObtenerColaProcesos().ToList();
                listaProcesos.Remove(proceso);


                GestorColas.ActualizarCola(listaProcesos);
            }
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

        private void txtIDProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTiempoLlegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTiempoCPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrioridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void datagridProcesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == datagridProcesos.Columns["btnMatar"].Index)
            {

                int procesoId = Convert.ToInt32(datagridProcesos.Rows[e.RowIndex].Cells["Id"].Value);


                EliminarProcesoPorId(procesoId);


                ActualizarDataGridView();
            }
        }
    }
}
