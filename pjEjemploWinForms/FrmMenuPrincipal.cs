using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjEjemploWinForms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            frmMembresia frm = new frmMembresia();
            AbrirFormEnPanel(frm);
        }

        private void AbrirFormEnPanel(frmMembresia frm)
        {
            if (pnlContenedorForm.Controls.Count > 0)
                pnlContenedorForm.Controls.RemoveAt(0);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlContenedorForm.Controls.Add(frm);
            pnlContenedorForm.Tag = frm;
            frm.Show();
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 230)
                tmExpandirMenu.Stop();
            else
                pnlMenu.Width += 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 55)
                tmContraerMenu.Stop();
            else
                pnlMenu.Width -= 5;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Width == 230)
                tmContraerMenu.Start();
            else if(pnlMenu.Width == 55)
                tmExpandirMenu.Start();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        int lx, ly;
        int sw, sh;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }
    }
}
