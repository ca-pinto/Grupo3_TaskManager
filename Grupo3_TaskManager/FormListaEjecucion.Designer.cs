﻿namespace Grupo3_TaskManager
{
    partial class FormListaEjecucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaEjecucion));
            label1 = new Label();
            cmbAlgoritmos = new ComboBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(624, 28);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el tipo de algoritmo con el que desea trabajar los procesos.";
            // 
            // cmbAlgoritmos
            // 
            cmbAlgoritmos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgoritmos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAlgoritmos.FormattingEnabled = true;
            cmbAlgoritmos.Items.AddRange(new object[] { "Planificación por Prioridad", "Round Robin", "Multicolas", "Trabajo más corto primero", "Planificación Garantizada", "Planificación por Sorteo", "Reparto Equitativo" });
            cmbAlgoritmos.Location = new Point(217, 192);
            cmbAlgoritmos.Margin = new Padding(3, 4, 3, 4);
            cmbAlgoritmos.Name = "cmbAlgoritmos";
            cmbAlgoritmos.Size = new Size(247, 33);
            cmbAlgoritmos.TabIndex = 1;
            cmbAlgoritmos.SelectedIndexChanged += cmbAlgoritmos_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.MidnightBlue;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(279, 353);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(133, 52);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormListaEjecucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(683, 439);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbAlgoritmos);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListaEjecucion";
            Text = "Definir Lista de Ejecución";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbAlgoritmos;
        private Button btnConfirmar;
    }
}