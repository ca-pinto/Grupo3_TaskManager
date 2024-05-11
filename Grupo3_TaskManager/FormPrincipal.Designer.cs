namespace Grupo3_TaskManager
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnAddProcesos = new Button();
            btnListaEjecucion = new Button();
            btnConfigSO = new Button();
            btnEmularTask = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddProcesos
            // 
            btnAddProcesos.BackColor = Color.MidnightBlue;
            btnAddProcesos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProcesos.ForeColor = SystemColors.ButtonHighlight;
            btnAddProcesos.Location = new Point(204, 163);
            btnAddProcesos.Name = "btnAddProcesos";
            btnAddProcesos.Size = new Size(157, 88);
            btnAddProcesos.TabIndex = 0;
            btnAddProcesos.Text = "Agregar Procesos";
            btnAddProcesos.UseVisualStyleBackColor = false;
            btnAddProcesos.Click += btnAddProcesos_Click;
            // 
            // btnListaEjecucion
            // 
            btnListaEjecucion.BackColor = Color.MidnightBlue;
            btnListaEjecucion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaEjecucion.ForeColor = SystemColors.ButtonHighlight;
            btnListaEjecucion.Location = new Point(204, 288);
            btnListaEjecucion.Name = "btnListaEjecucion";
            btnListaEjecucion.Size = new Size(157, 87);
            btnListaEjecucion.TabIndex = 1;
            btnListaEjecucion.Text = "Definir Lista Ejecución";
            btnListaEjecucion.UseVisualStyleBackColor = false;
            btnListaEjecucion.Click += btnListaEjecucion_Click;
            // 
            // btnConfigSO
            // 
            btnConfigSO.BackColor = Color.MidnightBlue;
            btnConfigSO.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfigSO.ForeColor = SystemColors.ButtonHighlight;
            btnConfigSO.Location = new Point(481, 163);
            btnConfigSO.Name = "btnConfigSO";
            btnConfigSO.Size = new Size(150, 88);
            btnConfigSO.TabIndex = 2;
            btnConfigSO.Text = "Configuración SO";
            btnConfigSO.UseVisualStyleBackColor = false;
            // 
            // btnEmularTask
            // 
            btnEmularTask.BackColor = Color.MidnightBlue;
            btnEmularTask.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmularTask.ForeColor = SystemColors.ButtonHighlight;
            btnEmularTask.Location = new Point(481, 287);
            btnEmularTask.Name = "btnEmularTask";
            btnEmularTask.Size = new Size(150, 87);
            btnEmularTask.TabIndex = 3;
            btnEmularTask.Text = "Emular Task Manager";
            btnEmularTask.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(285, 45);
            label1.Name = "label1";
            label1.Size = new Size(246, 50);
            label1.TabIndex = 4;
            label1.Text = "Task Manager";
            label1.Click += label1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEmularTask);
            Controls.Add(btnConfigSO);
            Controls.Add(btnListaEjecucion);
            Controls.Add(btnAddProcesos);
            Name = "FormPrincipal";
            Text = "Task Manager - Grupo 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProcesos;
        private Button btnListaEjecucion;
        private Button btnConfigSO;
        private Button btnEmularTask;
        private Label label1;
    }
}
