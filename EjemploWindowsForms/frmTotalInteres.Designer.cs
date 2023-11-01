namespace EjemploWindowsForms
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
            txtTiempo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Capital:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 92);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Razón:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 137);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Tiempo:";
            // 
            // txtCapital
            // 
            txtCapital.Location = new Point(120, 45);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(172, 23);
            txtCapital.TabIndex = 3;
            // 
            // txtRazon
            // 
            txtRazon.Location = new Point(120, 89);
            txtRazon.Name = "txtRazon";
            txtRazon.Size = new Size(172, 23);
            txtRazon.TabIndex = 4;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(120, 134);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(172, 23);
            txtTiempo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(341, 45);
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
            ClientSize = new Size(453, 201);
            Controls.Add(btnCalcular);
            Controls.Add(txtTiempo);
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
        private TextBox txtTiempo;
        private Button btnCalcular;
    }
}