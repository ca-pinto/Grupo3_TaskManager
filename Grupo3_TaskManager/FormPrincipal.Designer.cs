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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddProcesos
            // 
            btnAddProcesos.BackColor = Color.MidnightBlue;
            btnAddProcesos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProcesos.ForeColor = SystemColors.ButtonHighlight;
            btnAddProcesos.Location = new Point(328, 269);
            btnAddProcesos.Name = "btnAddProcesos";
            btnAddProcesos.Size = new Size(157, 88);
            btnAddProcesos.TabIndex = 0;
            btnAddProcesos.Text = "Iniciar";
            btnAddProcesos.UseVisualStyleBackColor = false;
            btnAddProcesos.Click += btnAddProcesos_Click;
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
            Controls.Add(btnAddProcesos);
            Name = "FormPrincipal";
            Text = "Task Manager - Grupo 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProcesos;
        //private Button btnConfigSO;
        private Label label1;
    }
}
