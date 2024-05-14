using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupo3_TaskManager
{
    public partial class FormListaEjecucion : Form
    {
        public string SeleccionCombo;
        public FormListaEjecucion()
        {
            InitializeComponent();
        }

        private void cmbAlgoritmos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionCombo = cmbAlgoritmos.SelectedItem.ToString();
            FormAddProcesos frmProcesos = new FormAddProcesos(SeleccionCombo);
            frmProcesos.ShowDialog();

        }
       
    }
}
