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

        internal SistemaOperativo SistemaOperativo { get; private set; }

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
            int quantum = Convert.ToInt32(txtQuantum.Text);

            SistemaOperativo = new SistemaOperativo(quantum);
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

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (SeleccionAlgoritmo == "Planificación Garantizada")
            {
                PlanGarantizada();

            }
            else if (SeleccionAlgoritmo == "Trabajo más corto primero")
            {
                AlgoritmoMasCorto();
            }
            else if (SeleccionAlgoritmo == "Planificación por Prioridad")
            {
                AlgoritmoPrioridad();
            }
            else if (SeleccionAlgoritmo == "Round Robin")
            {
                AlgoritmoRoundRobin(int.Parse(txtQuantum.Text));
            }
        }

        public async Task PlanGarantizada()
        {
            int distroQuantum = (SistemaOperativo.Quantum / GestorColas.ContarProcesos());

            foreach (Procesos proceso in GestorColas.ObtenerProcesosOrdenadosPorTiempoLlegada())
            {
                proceso.Estado = "Listo";
                var procesoActual = GestorColas.EliminarProceso();
                

                await Task.Delay(1500);
                if (procesoActual.TiempoCpu > 0)
                {
                    procesoActual.Estado = "Ejecución";
                    ActualizarDataGridView();

                    await Task.Delay(2000);

                    if (procesoActual.TiempoCpu <= distroQuantum)
                    {
                        await Task.Delay(2000);
                        procesoActual.TiempoCpu = 0;
                        procesoActual.Estado = "Finalizado";
                    }
                    else
                    {
                        procesoActual.TiempoCpu -= distroQuantum;
                        procesoActual.Estado = "Bloqueo";

                        GestorColas.AgregarProceso(procesoActual);
                    }
                    ActualizarDataGridView();
                    await Task.Delay(2000);
                }

            }

            foreach (var proceso in GestorColas.ObtenerColaProcesos().Where(p => p.Estado == "Bloqueo"))
            {
                await Task.Delay(2000);
                proceso.Estado = "Listo";
            }
            ActualizarDataGridView();
        }
        private async Task AlgoritmoMasCorto()
        {
            foreach (Procesos proceso in GestorColas.OrdenarPorTiempoCpu())
            {
                proceso.Estado = "Listo";
                var procesoActual = GestorColas.EliminarProceso();

                await Task.Delay(2500);

                if (procesoActual.TiempoCpu > 0)
                {
                    procesoActual.Estado = "Ejecución";
                    ActualizarDataGridView();

                    await Task.Delay(3000);

                    if (procesoActual.TiempoCpu <= SistemaOperativo.Quantum)
                    {
                        await Task.Delay(3000);
                        procesoActual.TiempoCpu = 0;
                        procesoActual.Estado = "Finalizado";
                    }
                    else
                    {
                        procesoActual.TiempoCpu -= SistemaOperativo.Quantum;
                        procesoActual.Estado = "Bloqueo";

                        GestorColas.AgregarProceso(procesoActual);
                    }
                    ActualizarDataGridView();
                    await Task.Delay(2000);
                }
            }
        }
        private async Task AlgoritmoPrioridad()
        {
            foreach (Procesos proceso in GestorColas.OrdenarPorPrioridad())
            {
                proceso.Estado = "Listo";
                var procesoActual = GestorColas.EliminarProceso();

                await Task.Delay(2500);

                if (procesoActual.TiempoCpu > 0)
                {
                    procesoActual.Estado = "Ejecución";
                    ActualizarDataGridView();

                    await Task.Delay(3000);

                    if (procesoActual.TiempoCpu <= SistemaOperativo.Quantum)
                    {
                        await Task.Delay(3000);
                        procesoActual.TiempoCpu = 0;
                        procesoActual.Estado = "Finalizado";
                    }
                    else
                    {
                        procesoActual.TiempoCpu -= SistemaOperativo.Quantum;
                        procesoActual.Estado = "Bloqueo";

                        GestorColas.AgregarProceso(procesoActual);
                    }
                    ActualizarDataGridView();
                    await Task.Delay(2000);
                }
            }
        }

        private async Task AlgoritmoRoundRobin(int quantum)
        {
            Queue<Procesos> cola = new Queue<Procesos>(GestorColas.ObtenerProcesosOrdenadosPorTiempoLlegada());

            while (cola.Count > 0)
            {
                Procesos proceso = cola.Dequeue();
                proceso.Estado = "Listo";

                await Task.Delay(1500);

                proceso.Estado = "Ejecución";
                ActualizarDataGridView();

                await Task.Delay(2000);

                if (proceso.TiempoCpu <= quantum)
                {
                    await Task.Delay(2000);
                    proceso.TiempoCpu = 0;
                    proceso.Estado = "Finalizado";
                }
                else
                {
                    await Task.Delay(2000);
                    proceso.TiempoCpu -= quantum;
                    proceso.Estado = "Bloqueo"; // Se coloca en estado de bloqueo temporal
                    cola.Enqueue(proceso); // Colocar el proceso al final de la cola
                }
                ActualizarDataGridView();
                await Task.Delay(2000);
            }
        }


    }
}
