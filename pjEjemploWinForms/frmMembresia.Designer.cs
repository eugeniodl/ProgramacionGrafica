namespace pjEjemploWinForms
{
    partial class frmMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembresia));
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvJubilacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJubilacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(38, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 53);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvJubilacion
            // 
            this.dgvJubilacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJubilacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvJubilacion.Location = new System.Drawing.Point(56, 95);
            this.dgvJubilacion.Name = "dgvJubilacion";
            this.dgvJubilacion.RowTemplate.Height = 25;
            this.dgvJubilacion.Size = new System.Drawing.Size(682, 150);
            this.dgvJubilacion.TabIndex = 1;
            this.dgvJubilacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJubilacion_CellContentClick);
            this.dgvJubilacion.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJubilacion_CellEnter);
            this.dgvJubilacion.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJubilacion_CellLeave);
            this.dgvJubilacion.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJubilacion_CellValidated);
            this.dgvJubilacion.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvJubilacion_CellValidating);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Años faltantes";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // frmMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvJubilacion);
            this.Controls.Add(this.btnClose);
            this.Name = "frmMembresia";
            this.Text = "frmMembresia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJubilacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClose;
        private DataGridView dgvJubilacion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}