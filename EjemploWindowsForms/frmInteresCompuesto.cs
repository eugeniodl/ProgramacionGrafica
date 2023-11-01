using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWindowsForms
{
    public partial class frmInteresCompuesto : Form
    {
        public frmInteresCompuesto()
        {
            InitializeComponent();
        }

        private void txtTotalInteres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmTotalInteres frmTotal = new frmTotalInteres();
                frmTotal.pasado += new frmTotalInteres.pasar(Ejecutar);
                frmTotal.ShowDialog();
            }
        }

        public void Ejecutar(string interes)
        {
            txtTotalInteres.Text = interes;
        }
    
    }
}
