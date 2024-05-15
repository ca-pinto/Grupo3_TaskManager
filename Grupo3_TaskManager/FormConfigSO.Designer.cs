namespace Grupo3_TaskManager
{
    partial class FormConfigSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigSO));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textMemo = new TextBox();
            btnSave = new Button();
            btnSalir = new Button();
            label4 = new Label();
            txtQuantum = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(323, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(182, 28);
            label2.Name = "label2";
            label2.Size = new Size(436, 51);
            label2.TabIndex = 1;
            label2.Text = "CONFIGURACIÓN DE SO";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(124, 220);
            label3.Name = "label3";
            label3.Size = new Size(199, 25);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Memoria:";
            // 
            // textMemo
            // 
            textMemo.Location = new Point(368, 222);
            textMemo.Name = "textMemo";
            textMemo.Size = new Size(146, 23);
            textMemo.TabIndex = 3;
            textMemo.TextChanged += textMemo_TextChanged;
            textMemo.KeyPress += textMemo_KeyPress;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(274, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MidnightBlue;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(433, 298);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 40);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(124, 166);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 20;
            label4.Text = "Quantum de Tiempo:";
            // 
            // txtQuantum
            // 
            txtQuantum.Location = new Point(368, 166);
            txtQuantum.Name = "txtQuantum";
            txtQuantum.Size = new Size(146, 23);
            txtQuantum.TabIndex = 21;
            txtQuantum.KeyPress += txtQuantum_KeyPress;
            // 
            // FormConfigSO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantum);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnSave);
            Controls.Add(textMemo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConfigSO";
            Text = "FormConfigSO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textMemo;
        private Button btnSave;
        private Button btnSalir;
        private Label label4;
        private TextBox txtQuantum;
    }
}