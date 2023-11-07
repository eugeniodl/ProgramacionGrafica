namespace EjemplosWindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delagadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoInterésCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadrosDeDiálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblInformacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenedoresToolStripMenuItem,
            this.delagadosToolStripMenuItem,
            this.cuadrosDeDiálogosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(733, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contenedoresToolStripMenuItem
            // 
            this.contenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabControlToolStripMenuItem});
            this.contenedoresToolStripMenuItem.Name = "contenedoresToolStripMenuItem";
            this.contenedoresToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.contenedoresToolStripMenuItem.Text = "Contenedores";
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // delagadosToolStripMenuItem
            // 
            this.delagadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálculoInterésCompuestoToolStripMenuItem});
            this.delagadosToolStripMenuItem.Name = "delagadosToolStripMenuItem";
            this.delagadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.delagadosToolStripMenuItem.Text = "Delegados";
            // 
            // cálculoInterésCompuestoToolStripMenuItem
            // 
            this.cálculoInterésCompuestoToolStripMenuItem.Name = "cálculoInterésCompuestoToolStripMenuItem";
            this.cálculoInterésCompuestoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.cálculoInterésCompuestoToolStripMenuItem.Text = "Cálculo Interés Compuesto";
            this.cálculoInterésCompuestoToolStripMenuItem.Click += new System.EventHandler(this.cálculoInterésCompuestoToolStripMenuItem_Click);
            // 
            // cuadrosDeDiálogosToolStripMenuItem
            // 
            this.cuadrosDeDiálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDialogToolStripMenuItem,
            this.fontDialogToolStripMenuItem,
            this.openFileDialogToolStripMenuItem,
            this.saveFileDialogToolStripMenuItem,
            this.folderBrowserDialogToolStripMenuItem});
            this.cuadrosDeDiálogosToolStripMenuItem.Name = "cuadrosDeDiálogosToolStripMenuItem";
            this.cuadrosDeDiálogosToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.cuadrosDeDiálogosToolStripMenuItem.Text = "Cuadros de diálogos";
            // 
            // colorDialogToolStripMenuItem
            // 
            this.colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            this.colorDialogToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.colorDialogToolStripMenuItem.Text = "ColorDialog";
            this.colorDialogToolStripMenuItem.Click += new System.EventHandler(this.colorDialogToolStripMenuItem_Click);
            // 
            // fontDialogToolStripMenuItem
            // 
            this.fontDialogToolStripMenuItem.Name = "fontDialogToolStripMenuItem";
            this.fontDialogToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.fontDialogToolStripMenuItem.Text = "FontDialog";
            this.fontDialogToolStripMenuItem.Click += new System.EventHandler(this.fontDialogToolStripMenuItem_Click);
            // 
            // openFileDialogToolStripMenuItem
            // 
            this.openFileDialogToolStripMenuItem.Name = "openFileDialogToolStripMenuItem";
            this.openFileDialogToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openFileDialogToolStripMenuItem.Text = "OpenFileDialog";
            this.openFileDialogToolStripMenuItem.Click += new System.EventHandler(this.openFileDialogToolStripMenuItem_Click);
            // 
            // saveFileDialogToolStripMenuItem
            // 
            this.saveFileDialogToolStripMenuItem.Name = "saveFileDialogToolStripMenuItem";
            this.saveFileDialogToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveFileDialogToolStripMenuItem.Text = "SaveFileDialog";
            this.saveFileDialogToolStripMenuItem.Click += new System.EventHandler(this.saveFileDialogToolStripMenuItem_Click);
            // 
            // folderBrowserDialogToolStripMenuItem
            // 
            this.folderBrowserDialogToolStripMenuItem.Name = "folderBrowserDialogToolStripMenuItem";
            this.folderBrowserDialogToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.folderBrowserDialogToolStripMenuItem.Text = "FolderBrowserDialog";
            this.folderBrowserDialogToolStripMenuItem.Click += new System.EventHandler(this.folderBrowserDialogToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblInformacion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblInformacion
            // 
            this.slblInformacion.Name = "slblInformacion";
            this.slblInformacion.Size = new System.Drawing.Size(21, 20);
            this.slblInformacion.Text = "   ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 434);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.Text = ".:.Uso de Formularios.:.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contenedoresToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem delagadosToolStripMenuItem;
        private ToolStripMenuItem cálculoInterésCompuestoToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblInformacion;
        private ToolStripMenuItem cuadrosDeDiálogosToolStripMenuItem;
        private ToolStripMenuItem colorDialogToolStripMenuItem;
        private ToolStripMenuItem fontDialogToolStripMenuItem;
        private ToolStripMenuItem openFileDialogToolStripMenuItem;
        private ToolStripMenuItem saveFileDialogToolStripMenuItem;
        private ToolStripMenuItem folderBrowserDialogToolStripMenuItem;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}