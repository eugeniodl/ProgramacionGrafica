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
    public partial class frmTotalInteres : Form
    {
        public delegate void pasar(string capital);
        public event pasar pasado;

        public frmTotalInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            pasado(CalcularInteres());
            this.Dispose();
        }

        private string CalcularInteres()
        {
            // Declaración de variables
            double capital, razon, tiempo;
            double interes, monto;

            capital = double.Parse(txtCapital.Text);
            razon = double.Parse(txtRazon.Text);
            tiempo = double.Parse(txtTiempo.Text);

            monto = Math.Pow((1 + razon), tiempo) * capital;
            interes = monto - capital;

            return Convert.ToString(interes);
        }
    }
}
