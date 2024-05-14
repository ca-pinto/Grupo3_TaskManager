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
    public partial class FormConfigSO : Form
    {
        public FormConfigSO()
        {
            InitializeComponent();
            //Procesos proceso = new Procesos();

        }
        public int Memoria {  get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textMemo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormPrincipal frm = new FormPrincipal();
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textMemo.Text, out int memoria1))
            {
                Memoria = memoria1;
                MessageBox.Show("Los Datos se han Guardado");

            }
            else
            {
                MessageBox.Show("Por Favor, Ingrese los datos");
            }
        }
    }
}
