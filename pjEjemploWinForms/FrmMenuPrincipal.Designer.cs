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
            pnlContenedorPrincipal = new Panel();
            pnlBarraTitulo = new Panel();
            pnlMenu = new Panel();
            panel1 = new Panel();
            pnlContenedorPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.BackColor = Color.FromArgb(64, 69, 76);
            pnlContenedorPrincipal.Controls.Add(panel1);
            pnlContenedorPrincipal.Controls.Add(pnlMenu);
            pnlContenedorPrincipal.Controls.Add(pnlBarraTitulo);
            pnlContenedorPrincipal.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Location = new Point(0, 0);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(1451, 699);
            pnlContenedorPrincipal.TabIndex = 0;
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
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(29, 34, 39);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 53);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(307, 646);
            pnlMenu.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedorPrincipal;
        private Panel pnlBarraTitulo;
        private Panel pnlMenu;
        private Panel panel1;
    }
}