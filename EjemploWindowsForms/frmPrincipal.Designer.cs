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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            contenedoresToolStripMenuItem = new ToolStripMenuItem();
            tabControlToolStripMenuItem = new ToolStripMenuItem();
            delegadosToolStripMenuItem = new ToolStripMenuItem();
            interésCompuestoToolStripMenuItem = new ToolStripMenuItem();
            cuadrosDeDiálogosToolStripMenuItem = new ToolStripMenuItem();
            colorDialogToolStripMenuItem = new ToolStripMenuItem();
            fontDialogToolStripMenuItem = new ToolStripMenuItem();
            openFileDialogToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialogToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialogToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            statusStrip1 = new StatusStrip();
            slblInformacion = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contenedoresToolStripMenuItem, delegadosToolStripMenuItem, cuadrosDeDiálogosToolStripMenuItem });
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
            interésCompuestoToolStripMenuItem.Size = new Size(174, 22);
            interésCompuestoToolStripMenuItem.Text = "Interés Compuesto";
            interésCompuestoToolStripMenuItem.Click += interésCompuestoToolStripMenuItem_Click;
            // 
            // cuadrosDeDiálogosToolStripMenuItem
            // 
            cuadrosDeDiálogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorDialogToolStripMenuItem, fontDialogToolStripMenuItem, openFileDialogToolStripMenuItem, saveFileDialogToolStripMenuItem, folderBrowserDialogToolStripMenuItem });
            cuadrosDeDiálogosToolStripMenuItem.Name = "cuadrosDeDiálogosToolStripMenuItem";
            cuadrosDeDiálogosToolStripMenuItem.Size = new Size(127, 20);
            cuadrosDeDiálogosToolStripMenuItem.Text = "Cuadros de diálogos";
            // 
            // colorDialogToolStripMenuItem
            // 
            colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            colorDialogToolStripMenuItem.Size = new Size(183, 22);
            colorDialogToolStripMenuItem.Text = "ColorDialog";
            colorDialogToolStripMenuItem.Click += colorDialogToolStripMenuItem_Click;
            // 
            // fontDialogToolStripMenuItem
            // 
            fontDialogToolStripMenuItem.Name = "fontDialogToolStripMenuItem";
            fontDialogToolStripMenuItem.Size = new Size(183, 22);
            fontDialogToolStripMenuItem.Text = "FontDialog";
            fontDialogToolStripMenuItem.Click += fontDialogToolStripMenuItem_Click;
            // 
            // openFileDialogToolStripMenuItem
            // 
            openFileDialogToolStripMenuItem.Name = "openFileDialogToolStripMenuItem";
            openFileDialogToolStripMenuItem.Size = new Size(183, 22);
            openFileDialogToolStripMenuItem.Text = "OpenFileDialog";
            openFileDialogToolStripMenuItem.Click += openFileDialogToolStripMenuItem_Click;
            // 
            // saveFileDialogToolStripMenuItem
            // 
            saveFileDialogToolStripMenuItem.Name = "saveFileDialogToolStripMenuItem";
            saveFileDialogToolStripMenuItem.Size = new Size(183, 22);
            saveFileDialogToolStripMenuItem.Text = "SaveFileDialog";
            saveFileDialogToolStripMenuItem.Click += saveFileDialogToolStripMenuItem_Click;
            // 
            // folderBrowserDialogToolStripMenuItem
            // 
            folderBrowserDialogToolStripMenuItem.Name = "folderBrowserDialogToolStripMenuItem";
            folderBrowserDialogToolStripMenuItem.Size = new Size(183, 22);
            folderBrowserDialogToolStripMenuItem.Text = "FolderBrowserDialog";
            folderBrowserDialogToolStripMenuItem.Click += folderBrowserDialogToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { slblInformacion });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // slblInformacion
            // 
            slblInformacion.Name = "slblInformacion";
            slblInformacion.Size = new Size(72, 17);
            slblInformacion.Text = "Información";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = ".:.Uso de Formularios.:.";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contenedoresToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem delegadosToolStripMenuItem;
        private ToolStripMenuItem interésCompuestoToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblInformacion;
    }
}