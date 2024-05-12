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
        public FormAddProcesos()
        {
            InitializeComponent();
            //Procesos proceso = new Procesos();

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

            datagridProcesos.Rows.Add(id, nombre, tiempoLlegada, tiempoCpu, prioridad);

            txtIDProceso.Clear();
            txtNombre.Clear();
            txtTiempoLlegada.Clear();
            txtTiempoCPU.Clear();
            txtPrioridad.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDProceso.Clear();
            txtNombre.Clear();
            txtTiempoLlegada.Clear();
            txtTiempoCPU.Clear();
            txtPrioridad.Clear();
        }
    }
}
