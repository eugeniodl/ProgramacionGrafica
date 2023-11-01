namespace EjemploWindowsForms
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            contenedoresToolStripMenuItem = new ToolStripMenuItem();
            tabControlToolStripMenuItem = new ToolStripMenuItem();
            delegadosToolStripMenuItem = new ToolStripMenuItem();
            interésCompuestoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contenedoresToolStripMenuItem, delegadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contenedoresToolStripMenuItem
            // 
            contenedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tabControlToolStripMenuItem });
            contenedoresToolStripMenuItem.Name = "contenedoresToolStripMenuItem";
            contenedoresToolStripMenuItem.Size = new Size(93, 20);
            contenedoresToolStripMenuItem.Text = "Contenedores";
            // 
            // tabControlToolStripMenuItem
            // 
            tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            tabControlToolStripMenuItem.Size = new Size(132, 22);
            tabControlToolStripMenuItem.Text = "TabControl";
            tabControlToolStripMenuItem.Click += tabControlToolStripMenuItem_Click;
            // 
            // delegadosToolStripMenuItem
            // 
            delegadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { interésCompuestoToolStripMenuItem });
            delegadosToolStripMenuItem.Name = "delegadosToolStripMenuItem";
            delegadosToolStripMenuItem.Size = new Size(74, 20);
            delegadosToolStripMenuItem.Text = "Delegados";
            // 
            // interésCompuestoToolStripMenuItem
            // 
            interésCompuestoToolStripMenuItem.Name = "interésCompuestoToolStripMenuItem";
            interésCompuestoToolStripMenuItem.Size = new Size(180, 22);
            interésCompuestoToolStripMenuItem.Text = "Interés Compuesto";
            interésCompuestoToolStripMenuItem.Click += interésCompuestoToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = ".:.Uso de Formularios.:.";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contenedoresToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem delegadosToolStripMenuItem;
        private ToolStripMenuItem interésCompuestoToolStripMenuItem;
    }
}