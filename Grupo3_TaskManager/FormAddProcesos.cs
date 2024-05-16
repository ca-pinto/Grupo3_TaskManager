using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            var procesos = GestorColas.ObtenerColaProcesos().ToList();

            foreach (Procesos proceso in procesos)
            {
                bool encontrado = false;

                // Buscar si el proceso ya existe en el DataGridView
                foreach (DataGridViewRow row in datagridProcesos.Rows)
                {
                    var cellValue = row.Cells["Id"].Value;
                    if (cellValue != null && cellValue.ToString() == proceso.Id.ToString())
                    {
                        // Actualizar la fila existente
                        row.Cells["Nombre"].Value = proceso.Nombre;
                        row.Cells["TiempoLlegada"].Value = proceso.TiempoLlegada;
                        row.Cells["TiempoCpu"].Value = proceso.TiempoCpu;
                        row.Cells["Prioridad"].Value = proceso.Prioridad;
                        row.Cells["Estado"].Value = proceso.Estado;
                        row.Cells["Terminado"].Value = proceso.Terminado;
                        row.Cells["Algoritmo"].Value = proceso.Algoritmo;
                        row.Cells["Sorteo"].Value = proceso.Sorteo.HasValue ? (object)proceso.Sorteo.Value.ToString() : DBNull.Value;
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    // Si no se encontró el proceso, agregarlo como una nueva fila
                    object valorSorteo = proceso.Sorteo.HasValue ? (object)proceso.Sorteo.Value.ToString() : DBNull.Value;
                    datagridProcesos.Rows.Add(proceso.Id, proceso.Nombre, proceso.TiempoLlegada, proceso.TiempoCpu, proceso.Prioridad, proceso.Estado, proceso.Terminado, proceso.Algoritmo, valorSorteo);
                }
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

                // Llamar al método que elimina el proceso por Id
                GestorColas.EliminarProcesoPorId(procesoId);

                // Actualizar el DataGridView
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
            else if (SeleccionAlgoritmo == "Planificación por Sorteo")
            {
                PlanSorteo();
            }
        }

        public async Task PlanGarantizada()
        {
            int distroQuantum = (SistemaOperativo.Quantum / GestorColas.ContarProcesos());
            txtQuantum.Text = distroQuantum.ToString();
            txtQuantum.Enabled = false;

            while(GestorColas.ContarProcesos() > 0)
            {
                foreach (Procesos proceso in GestorColas.ObtenerProcesosOrdenadosPorTiempoLlegada())
                {
                    if (proceso.TiempoCpu > 0)
                    {
                        proceso.Estado = "Listo";
                    }
                    var procesoActual = GestorColas.EliminarProceso();
                    var aux = procesoActual;
                    GestorColas.AgregarProceso(aux);

                    await Task.Delay(1500);
                    if (procesoActual.TiempoCpu > 0)
                    {
                        procesoActual.Estado = "Ejecución";
                        procesoActual.TiempoCpu -= distroQuantum;
                        ActualizarDataGridView();

                        await Task.Delay(2000);

                        if (procesoActual.TiempoCpu <= 0)
                        {
                            await Task.Delay(2000);
                            procesoActual.TiempoCpu = 0;
                            procesoActual.Estado = "Finalizado";
                        }
                        else
                        {
                            procesoActual.Estado = "Bloqueo";

                            GestorColas.AgregarProceso(procesoActual);
                        }
                        ActualizarDataGridView();
                        await Task.Delay(2000);
                    }
                }

            }

            foreach (var proceso in GestorColas.ObtenerColaProcesos().Where(p => p.Estado == "Bloqueo"))
            {
                await Task.Delay(2000);
                if (proceso.TiempoCpu > 0){
                    proceso.Estado = "Listo";
                }
            }
            ActualizarDataGridView();
        }
        private async Task AlgoritmoMasCorto()
        {
            var procesosOrdenados = GestorColas.OrdenarPorTiempoCpu();

            foreach (Procesos proceso in procesosOrdenados)
            {
                proceso.Estado = "Listo";

                ActualizarDataGridView();
                var procesoActual = GestorColas.EliminarProceso();

                await Task.Delay(1500);

                if (proceso.TiempoCpu > 0)
                {
                    proceso.Estado = "Ejecución";
                    ActualizarDataGridView();

                    await Task.Delay(2000);

                    if (proceso.TiempoCpu <= SistemaOperativo.Quantum)
                    {
                        await Task.Delay(2000);
                        proceso.TiempoCpu = 0;
                        proceso.Estado = "Finalizado";
                    }
                    else
                    {
                        proceso.TiempoCpu -= SistemaOperativo.Quantum;
                        proceso.Estado = "Bloqueo";

                        GestorColas.AgregarProceso(proceso);
                    }
                    ActualizarDataGridView();
                }
            }
        }
        private async Task AlgoritmoPrioridad()
        {
            var procesosOrdenados = GestorColas.OrdenarPorPrioridad();

            foreach (Procesos proceso in procesosOrdenados)
            {
                proceso.Estado = "Listo";

                ActualizarDataGridView();

                await Task.Delay(1500);

                if (proceso.TiempoCpu > 0)
                {
                    proceso.Estado = "Ejecución";
                    ActualizarDataGridView();
                    await Task.Delay(2000);

                    if (proceso.TiempoCpu <= SistemaOperativo.Quantum)
                    {
                        await Task.Delay(2000);
                        proceso.TiempoCpu = 0;
                        proceso.Estado = "Finalizado";
                        proceso.Terminado = true;
                    }
                    else
                    {
                        proceso.TiempoCpu -= SistemaOperativo.Quantum;
                        proceso.Estado = "Bloqueo";

                        GestorColas.AgregarProceso(proceso);
                    }

                    foreach (Procesos procesos in procesosOrdenados.Where(p => p.Estado == "Bloqueo"))
                    {
                        await Task.Delay(2000);
                        procesos.Estado = "Listo";
                    }
                    ActualizarDataGridView();
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

        public async Task PlanSorteo()
        {
            const int delay = 2000;
            Random random = new Random();

            while (GestorColas.ContarProcesos() > 0)
            {

                if (GestorColas.ContarProcesos() == 0)
                    break;


                foreach (Procesos proceso in GestorColas.ObtenerColaProcesos())
                {
                    proceso.Tickets = CalcularTickets(proceso.Prioridad);
                }

                int totalTickets = GestorColas.ObtenerColaProcesos().Sum(proceso => proceso.Tickets);

                int ticketGanador = random.Next(1, totalTickets + 1);
                int ticketsAcumulados = 0;
                Procesos procesoActual = null;

                foreach (Procesos proceso in GestorColas.ObtenerColaProcesos())
                {
                    ticketsAcumulados += proceso.Tickets;

                    if (ticketGanador <= ticketsAcumulados)
                    {
                        procesoActual = proceso;
                        break;
                    }
                }

                if (procesoActual != null)
                {
                    GestorColas.EliminarProceso();

                    procesoActual.Estado = "Ejecución";
                    ActualizarDataGridView();
                    await Task.Delay(delay);

                    if (procesoActual.TiempoCpu <= SistemaOperativo.Quantum)
                    {
                        await Task.Delay(delay);
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
                    await Task.Delay(delay);
                }
            }

            foreach (var proceso in GestorColas.ObtenerColaProcesos().Where(p => p.Estado == "Bloqueo"))
            {
                await Task.Delay(delay);
                proceso.Estado = "Listo";
            }
            ActualizarDataGridView();
        }
        private int CalcularTickets(int prioridad)
        {

            const int Bajo = 1;
            const int Medio = 2;
            const int Alto = 3;


            switch (prioridad)
            {
                case 1:
                    return Bajo;
                case 2:
                    return Medio;
                case 3:
                    return Alto;
                default:
                    return 0;
            }
        }
    }
}
