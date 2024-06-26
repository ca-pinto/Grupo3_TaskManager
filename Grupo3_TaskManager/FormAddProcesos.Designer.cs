﻿namespace Grupo3_TaskManager
{
    partial class FormAddProcesos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProcesos));
            label1 = new Label();
            label2 = new Label();
            txtIDProceso = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtTiempoLlegada = new TextBox();
            label5 = new Label();
            txtTiempoCPU = new TextBox();
            label6 = new Label();
            txtPrioridad = new TextBox();
            label7 = new Label();
            txtEstado = new TextBox();
            label8 = new Label();
            rdbTrue = new RadioButton();
            rdbFalse = new RadioButton();
            label9 = new Label();
            btnAdd = new Button();
            btnFin = new Button();
            btnClear = new Button();
            datagridProcesos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TiempoLlegada = new DataGridViewTextBoxColumn();
            TiempoCpu = new DataGridViewTextBoxColumn();
            Prioridad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Terminado = new DataGridViewTextBoxColumn();
            Algoritmo = new DataGridViewTextBoxColumn();
            Sorteo = new DataGridViewTextBoxColumn();
            btnMatar = new DataGridViewButtonColumn();
            btnEjecutar = new Button();
            dataGridView1 = new DataGridView();
            txtSorteo = new TextBox();
            label10 = new Label();
            txtQuantum = new TextBox();
            label11 = new Label();
            txtMemoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)datagridProcesos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(333, 20);
            label1.Name = "label1";
            label1.Size = new Size(314, 51);
            label1.TabIndex = 0;
            label1.Text = "Agregar Procesos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 116);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "ID Proceso";
            label2.Click += label2_Click;
            // 
            // txtIDProceso
            // 
            txtIDProceso.BackColor = SystemColors.InactiveCaption;
            txtIDProceso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDProceso.ForeColor = SystemColors.WindowText;
            txtIDProceso.Location = new Point(138, 116);
            txtIDProceso.Margin = new Padding(3, 2, 3, 2);
            txtIDProceso.Name = "txtIDProceso";
            txtIDProceso.Size = new Size(163, 29);
            txtIDProceso.TabIndex = 2;
            txtIDProceso.TextAlign = HorizontalAlignment.Center;
            txtIDProceso.TextChanged += txtIDProceso_TextChanged;
            txtIDProceso.KeyPress += txtIDProceso_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 160);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(138, 160);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 29);
            txtNombre.TabIndex = 4;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(26, 211);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 5;
            label4.Text = "Tiempo Llegada (s)";
            // 
            // txtTiempoLlegada
            // 
            txtTiempoLlegada.BackColor = SystemColors.InactiveCaption;
            txtTiempoLlegada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTiempoLlegada.ForeColor = SystemColors.WindowText;
            txtTiempoLlegada.Location = new Point(213, 211);
            txtTiempoLlegada.Margin = new Padding(3, 2, 3, 2);
            txtTiempoLlegada.Name = "txtTiempoLlegada";
            txtTiempoLlegada.Size = new Size(88, 29);
            txtTiempoLlegada.TabIndex = 6;
            txtTiempoLlegada.TextAlign = HorizontalAlignment.Center;
            txtTiempoLlegada.KeyPress += txtTiempoLlegada_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 256);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 7;
            label5.Text = "Tiempo CPU (s)";
            // 
            // txtTiempoCPU
            // 
            txtTiempoCPU.BackColor = SystemColors.InactiveCaption;
            txtTiempoCPU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTiempoCPU.ForeColor = SystemColors.WindowText;
            txtTiempoCPU.Location = new Point(213, 252);
            txtTiempoCPU.Margin = new Padding(3, 2, 3, 2);
            txtTiempoCPU.Name = "txtTiempoCPU";
            txtTiempoCPU.Size = new Size(88, 29);
            txtTiempoCPU.TabIndex = 8;
            txtTiempoCPU.TextAlign = HorizontalAlignment.Center;
            txtTiempoCPU.KeyPress += txtTiempoCPU_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(363, 116);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 9;
            label6.Text = "Prioridad";
            // 
            // txtPrioridad
            // 
            txtPrioridad.BackColor = SystemColors.InactiveCaption;
            txtPrioridad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrioridad.ForeColor = SystemColors.WindowText;
            txtPrioridad.Location = new Point(462, 112);
            txtPrioridad.Margin = new Padding(3, 2, 3, 2);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(163, 29);
            txtPrioridad.TabIndex = 10;
            txtPrioridad.TextAlign = HorizontalAlignment.Center;
            txtPrioridad.TextChanged += txtPrioridad_TextChanged;
            txtPrioridad.KeyPress += txtPrioridad_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(363, 160);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 11;
            label7.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.InactiveCaption;
            txtEstado.Enabled = false;
            txtEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.ForeColor = SystemColors.WindowText;
            txtEstado.Location = new Point(462, 156);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(163, 29);
            txtEstado.TabIndex = 12;
            txtEstado.Text = "Inicio";
            txtEstado.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(363, 211);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 13;
            label8.Text = "Terminado";
            // 
            // rdbTrue
            // 
            rdbTrue.AutoSize = true;
            rdbTrue.BackColor = Color.Transparent;
            rdbTrue.Enabled = false;
            rdbTrue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbTrue.ForeColor = SystemColors.ButtonHighlight;
            rdbTrue.Location = new Point(476, 216);
            rdbTrue.Margin = new Padding(3, 2, 3, 2);
            rdbTrue.Name = "rdbTrue";
            rdbTrue.Size = new Size(36, 24);
            rdbTrue.TabIndex = 14;
            rdbTrue.Text = "V";
            rdbTrue.UseVisualStyleBackColor = false;
            // 
            // rdbFalse
            // 
            rdbFalse.AutoSize = true;
            rdbFalse.BackColor = Color.Transparent;
            rdbFalse.Checked = true;
            rdbFalse.Enabled = false;
            rdbFalse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbFalse.ForeColor = SystemColors.ButtonHighlight;
            rdbFalse.Location = new Point(532, 216);
            rdbFalse.Margin = new Padding(3, 2, 3, 2);
            rdbFalse.Name = "rdbFalse";
            rdbFalse.Size = new Size(34, 24);
            rdbFalse.TabIndex = 15;
            rdbFalse.TabStop = true;
            rdbFalse.Text = "F";
            rdbFalse.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(363, 256);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 16;
            label9.Text = "Sorteo";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(679, 208);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 40);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_click;
            // 
            // btnFin
            // 
            btnFin.BackColor = Color.MidnightBlue;
            btnFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFin.ForeColor = SystemColors.ButtonHighlight;
            btnFin.Location = new Point(824, 268);
            btnFin.Margin = new Padding(3, 2, 3, 2);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(113, 40);
            btnFin.TabIndex = 18;
            btnFin.Text = "Finalizar";
            btnFin.UseVisualStyleBackColor = false;
            btnFin.Click += btnFin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MidnightBlue;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(679, 268);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 40);
            btnClear.TabIndex = 19;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // datagridProcesos
            // 
            datagridProcesos.BackgroundColor = SystemColors.InactiveCaption;
            datagridProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridProcesos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, TiempoLlegada, TiempoCpu, Prioridad, Estado, Terminado, Algoritmo, Sorteo, btnMatar });
            datagridProcesos.Location = new Point(23, 340);
            datagridProcesos.Name = "datagridProcesos";
            datagridProcesos.RowHeadersWidth = 51;
            datagridProcesos.Size = new Size(914, 272);
            datagridProcesos.TabIndex = 20;
            datagridProcesos.CellContentClick += datagridProcesos_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID Proceso";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 75;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // TiempoLlegada
            // 
            TiempoLlegada.HeaderText = "Tiempo de Llegada";
            TiempoLlegada.MinimumWidth = 6;
            TiempoLlegada.Name = "TiempoLlegada";
            TiempoLlegada.Width = 75;
            // 
            // TiempoCpu
            // 
            TiempoCpu.HeaderText = "Tiempo de CPU";
            TiempoCpu.MinimumWidth = 6;
            TiempoCpu.Name = "TiempoCpu";
            TiempoCpu.Width = 75;
            // 
            // Prioridad
            // 
            Prioridad.HeaderText = "Prioridad";
            Prioridad.MinimumWidth = 6;
            Prioridad.Name = "Prioridad";
            Prioridad.Width = 75;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 85;
            // 
            // Terminado
            // 
            Terminado.HeaderText = "Terminado";
            Terminado.MinimumWidth = 6;
            Terminado.Name = "Terminado";
            Terminado.Width = 75;
            // 
            // Algoritmo
            // 
            Algoritmo.HeaderText = "Algoritmo";
            Algoritmo.MinimumWidth = 6;
            Algoritmo.Name = "Algoritmo";
            Algoritmo.Width = 125;
            // 
            // Sorteo
            // 
            Sorteo.HeaderText = "Sorteo";
            Sorteo.MinimumWidth = 6;
            Sorteo.Name = "Sorteo";
            Sorteo.Width = 75;
            // 
            // btnMatar
            // 
            btnMatar.HeaderText = "Matar";
            btnMatar.Name = "btnMatar";
            btnMatar.Text = "x";
            btnMatar.Width = 75;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.MidnightBlue;
            btnEjecutar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = SystemColors.ButtonHighlight;
            btnEjecutar.Location = new Point(824, 208);
            btnEjecutar.Margin = new Padding(3, 2, 3, 2);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(113, 40);
            btnEjecutar.TabIndex = 21;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(587, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 22;
            // 
            // txtSorteo
            // 
            txtSorteo.BackColor = SystemColors.InactiveCaption;
            txtSorteo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSorteo.ForeColor = SystemColors.WindowText;
            txtSorteo.Location = new Point(462, 256);
            txtSorteo.Margin = new Padding(3, 2, 3, 2);
            txtSorteo.Name = "txtSorteo";
            txtSorteo.Size = new Size(163, 29);
            txtSorteo.TabIndex = 23;
            txtSorteo.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(679, 112);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 24;
            label10.Text = "Quantum";
            // 
            // txtQuantum
            // 
            txtQuantum.BackColor = SystemColors.InactiveCaption;
            txtQuantum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantum.ForeColor = SystemColors.WindowText;
            txtQuantum.Location = new Point(774, 116);
            txtQuantum.Margin = new Padding(3, 2, 3, 2);
            txtQuantum.Name = "txtQuantum";
            txtQuantum.Size = new Size(163, 29);
            txtQuantum.TabIndex = 25;
            txtQuantum.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(679, 164);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 26;
            label11.Text = "Memoria";
            // 
            // txtMemoria
            // 
            txtMemoria.BackColor = SystemColors.InactiveCaption;
            txtMemoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMemoria.ForeColor = SystemColors.WindowText;
            txtMemoria.Location = new Point(774, 164);
            txtMemoria.Margin = new Padding(3, 2, 3, 2);
            txtMemoria.Name = "txtMemoria";
            txtMemoria.Size = new Size(163, 29);
            txtMemoria.TabIndex = 27;
            txtMemoria.TextAlign = HorizontalAlignment.Center;
            // 
            // FormAddProcesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(968, 661);
            Controls.Add(txtMemoria);
            Controls.Add(label11);
            Controls.Add(txtQuantum);
            Controls.Add(label10);
            Controls.Add(txtSorteo);
            Controls.Add(dataGridView1);
            Controls.Add(btnEjecutar);
            Controls.Add(datagridProcesos);
            Controls.Add(btnClear);
            Controls.Add(btnFin);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(rdbFalse);
            Controls.Add(rdbTrue);
            Controls.Add(label8);
            Controls.Add(txtEstado);
            Controls.Add(label7);
            Controls.Add(txtPrioridad);
            Controls.Add(label6);
            Controls.Add(txtTiempoCPU);
            Controls.Add(label5);
            Controls.Add(txtTiempoLlegada);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIDProceso);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddProcesos";
            Text = "Agregar Procesos";
            Load += FormAddProcesos_Load;
            ((System.ComponentModel.ISupportInitialize)datagridProcesos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIDProceso;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtTiempoLlegada;
        private Label label5;
        private TextBox txtTiempoCPU;
        private Label label6;
        private TextBox txtPrioridad;
        private Label label7;
        private TextBox txtEstado;
        private Label label8;
        private RadioButton rdbTrue;
        private RadioButton rdbFalse;
        private Label label9;
        private Button btnAdd;
        private Button btnFin;
        private Button btnClear;
        private DataGridView datagridProcesos;
        private Button btnEjecutar;
        private DataGridView dataGridView1;
        private TextBox txtSorteo;
        private Label label10;
        private TextBox txtQuantum;
        private Label label11;
        private TextBox txtMemoria;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TiempoLlegada;
        private DataGridViewTextBoxColumn TiempoCpu;
        private DataGridViewTextBoxColumn Prioridad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Terminado;
        private DataGridViewTextBoxColumn Algoritmo;
        private DataGridViewTextBoxColumn Sorteo;
        private DataGridViewButtonColumn btnMatar;
    }
}