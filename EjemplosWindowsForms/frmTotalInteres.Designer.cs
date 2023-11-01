namespace EjemplosWindowsForms
{
    partial class frmTotalInteres
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
            label2 = new Label();
            label3 = new Label();
            txtCapital = new TextBox();
            txtRazon = new TextBox();
            txtPlazo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Capital:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Razón:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 134);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Plazo:";
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(129, 37);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(100, 23);
            txtCapital.TabIndex = 3;
            // 
            // txtRazon
            // 
            txtRazon.Location = new Point(129, 84);
            txtRazon.Name = "txtRazon";
            txtRazon.Size = new Size(100, 23);
            txtRazon.TabIndex = 4;
            // 
            // txtPlazo
            // 
            txtPlazo.Location = new Point(129, 131);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.Size = new Size(100, 23);
            txtPlazo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(343, 36);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmTotalInteres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 219);
            Controls.Add(btnCalcular);
            Controls.Add(txtPlazo);
            Controls.Add(txtRazon);
            Controls.Add(txtCapital);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTotalInteres";
            Text = "frmTotalInteres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCapital;
        private TextBox txtRazon;
        private TextBox txtPlazo;
        private Button btnCalcular;
    }
}