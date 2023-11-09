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
    public partial class frmMembresia : Form
    {
        public frmMembresia()
        {
            InitializeComponent();
            Insertar();
        }

        private void Insertar()
        {
            int index = dgvJubilacion.Rows.Add();
            dgvJubilacion.Rows[index].Cells[0].Value = 21210398;
            dgvJubilacion.Rows[index].Cells[1].Value = "Marcelo";
            dgvJubilacion.Rows[index].Cells[2].Value = 21;
            dgvJubilacion.Rows[index].Cells[3].Value = 44;

            index = dgvJubilacion.Rows.Add();
            dgvJubilacion.Rows[index].Cells[0].Value = 21010394;
            dgvJubilacion.Rows[index].Cells[1].Value = "Ana";
            dgvJubilacion.Rows[index].Cells[2].Value = 59;
            dgvJubilacion.Rows[index].Cells[3].Value = 6;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvJubilacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Datos almacenados exitosamente");
        }

        private void dgvJubilacion_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                bool entero = int.TryParse(e.FormattedValue.ToString(),
                    out int resultadonumerico);

                if (entero)
                {
                    if (resultadonumerico < 18 || resultadonumerico > 65)
                    {
                        e.Cancel = true;
                        MessageBox.Show("La edad debe estar entre 18 y 65 años");
                    }
                }
                else
                {
                    e.Cancel = true; // esto se hace para que la celda no pierda el foco
                    MessageBox.Show("Se deben ingresar un valor numérico para la edad");
                }
            }
        }

        private void dgvJubilacion_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int nuevaEdad = Convert.ToInt32(dgvJubilacion.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex].Value.ToString());

                // Calculamos una nueva edad
                int aniosRestantes = 65 - nuevaEdad;
                dgvJubilacion.Rows[e.RowIndex].Cells[3].Value = aniosRestantes;
            }
        }

        private void dgvJubilacion_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvJubilacion[e.ColumnIndex, e.RowIndex].Style
                .SelectionBackColor = Color.Red;
        }

        private void dgvJubilacion_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvJubilacion[e.ColumnIndex, e.RowIndex].Style
                .SelectionBackColor = Color.Empty;
        }
    }
}
