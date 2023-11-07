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
    public partial class frmTabControl : Form
    {

        public frmTabControl()
        {
            InitializeComponent();
        }

        private void mtxtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                slblMensaje.Text = mtxtCedula.Text;
            }
        }

        private void mtxtCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            slblMensaje.Text = "Error al introducir el dato";
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            bool error = false;

            if (e.KeyCode == Keys.Enter)
            {
                foreach (char caracter in txtNombres.Text)
                {
                    if (char.IsDigit(caracter))
                    {
                        error = true;
                        break;
                    }
                }
            }

            // Verificamos por la condición de error
            if (error)
                errorProvider1.SetError(txtNombres,
                    "No se admiten números");
            else
                errorProvider1.Clear();

        }
    }
}
