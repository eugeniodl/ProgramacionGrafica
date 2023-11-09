namespace pjEjemploWinForms
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            pnlContenedorPrincipal = new Panel();
            panel1 = new Panel();
            pnlMenu = new Panel();
            pnlBarraTitulo = new Panel();
            pnlContenedorForm = new Panel();
            btnMembresia = new Button();
            pnlContenedorPrincipal.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.BackColor = Color.FromArgb(64, 69, 76);
            pnlContenedorPrincipal.Controls.Add(pnlContenedorForm);
            pnlContenedorPrincipal.Controls.Add(panel1);
            pnlContenedorPrincipal.Controls.Add(pnlMenu);
            pnlContenedorPrincipal.Controls.Add(pnlBarraTitulo);
            pnlContenedorPrincipal.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Location = new Point(0, 0);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(1451, 699);
            pnlContenedorPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 61, 69);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(307, 599);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 100);
            panel1.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(29, 34, 39);
            pnlMenu.Controls.Add(btnMembresia);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 53);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(307, 646);
            pnlMenu.TabIndex = 1;
            // 
            // pnlBarraTitulo
            // 
            pnlBarraTitulo.BackColor = Color.FromArgb(214, 61, 92);
            pnlBarraTitulo.Dock = DockStyle.Top;
            pnlBarraTitulo.Location = new Point(0, 0);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(1451, 53);
            pnlBarraTitulo.TabIndex = 0;
            // 
            // pnlContenedorForm
            // 
            pnlContenedorForm.Dock = DockStyle.Fill;
            pnlContenedorForm.Location = new Point(307, 53);
            pnlContenedorForm.Name = "pnlContenedorForm";
            pnlContenedorForm.Size = new Size(1144, 546);
            pnlContenedorForm.TabIndex = 3;
            // 
            // btnMembresia
            // 
            btnMembresia.Cursor = Cursors.Hand;
            btnMembresia.FlatAppearance.BorderSize = 0;
            btnMembresia.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 69, 76);
            btnMembresia.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 45, 53);
            btnMembresia.FlatStyle = FlatStyle.Flat;
            btnMembresia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMembresia.ForeColor = Color.Silver;
            btnMembresia.Image = (Image)resources.GetObject("btnMembresia.Image");
            btnMembresia.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembresia.Location = new Point(0, 62);
            btnMembresia.Name = "btnMembresia";
            btnMembresia.Size = new Size(304, 44);
            btnMembresia.TabIndex = 0;
            btnMembresia.Text = "Membresía";
            btnMembresia.TextAlign = ContentAlignment.MiddleLeft;
            btnMembresia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembresia.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 699);
            Controls.Add(pnlContenedorPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuPrincipal";
            Opacity = 0.95D;
            Text = "FrmMenuPrincipal";
            pnlContenedorPrincipal.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedorPrincipal;
        private Panel pnlBarraTitulo;
        private Panel pnlMenu;
        private Panel panel1;
        private Panel pnlContenedorForm;
        private Button btnMembresia;
    }
}