using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosWindowsForms
{
    public partial class frmPrincipal : Form
    {
        DialogResult result;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabControl frmTabControl = new frmTabControl();
            frmTabControl.MdiParent = this;
            frmTabControl.Show();
        }

        private void cálculoInterésCompuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInteres frmInteres = new frmInteres();
            frmInteres.MdiParent = this;
            frmInteres.Show();
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = colorDialog1.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                slblInformacion.Text = colorDialog1.Color.Name;
            }
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = fontDialog1.ShowDialog();
            if (result != DialogResult.Cancel)
                slblInformacion.Text = fontDialog1.Font.Name;
        }

        private void openFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = openFileDialog1.ShowDialog();
            if(result != DialogResult.Cancel)
                slblInformacion.Text = openFileDialog1.FileName;
        }

        private void saveFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = saveFileDialog1.ShowDialog();
            if( result != DialogResult.Cancel)
                slblInformacion.Text = 
                    $"Escogido: {saveFileDialog1.FileName}";
        }

        private void folderBrowserDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.Cancel)
                slblInformacion.Text = 
                    folderBrowserDialog1.SelectedPath;
        }
    }
}
