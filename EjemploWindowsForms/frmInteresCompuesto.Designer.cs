namespace EjemploWindowsForms
{
    partial class frmInteresCompuesto
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
            label1 = new Label();
            txtTotalInteres = new TextBox();
            label2 = new Label();
            txtMontoFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Interés:";
            // 
            // txtTotalInteres
            // 
            txtTotalInteres.Location = new Point(131, 50);
            txtTotalInteres.Name = "txtTotalInteres";
            txtTotalInteres.Size = new Size(130, 23);
            txtTotalInteres.TabIndex = 1;
            txtTotalInteres.KeyDown += txtTotalInteres_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 101);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Monto Final:";
            // 
            // txtMontoFinal
            // 
            txtMontoFinal.Location = new Point(131, 98);
            txtMontoFinal.Name = "txtMontoFinal";
            txtMontoFinal.Size = new Size(130, 23);
            txtMontoFinal.TabIndex = 3;
            // 
            // frmInteresCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 194);
            Controls.Add(txtMontoFinal);
            Controls.Add(label2);
            Controls.Add(txtTotalInteres);
            Controls.Add(label1);
            Name = "frmInteresCompuesto";
            Text = "Interés Compuesto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTotalInteres;
        private Label label2;
        private TextBox txtMontoFinal;
    }
}