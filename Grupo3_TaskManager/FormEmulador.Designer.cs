namespace Grupo3_TaskManager
{
    partial class FormEmulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmulador));
            dataGridProcesos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProcesos).BeginInit();
            SuspendLayout();
            // 
            // dataGridProcesos
            // 
            dataGridProcesos.BackgroundColor = SystemColors.InactiveCaption;
            dataGridProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProcesos.Location = new Point(58, 235);
            dataGridProcesos.Name = "dataGridProcesos";
            dataGridProcesos.Size = new Size(855, 272);
            dataGridProcesos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(133, 84);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // FormEmulador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(963, 535);
            Controls.Add(label1);
            Controls.Add(dataGridProcesos);
            Name = "FormEmulador";
            Text = "FormEmulador";
            ((System.ComponentModel.ISupportInitialize)dataGridProcesos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProcesos;
        private Label label1;
    }
}