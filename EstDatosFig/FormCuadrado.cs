using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstDatosFig
{
    public partial class FormCuadrado : Form
    {
        public FormCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLado.Text, out double lado))
            {
                double area = lado * lado;
                double perimetro = 4 * lado;

                lblArea.Text = $"Área: {area}";
                lblPerimetro.Text = $"Perímetro: {perimetro}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor válido.");
            }
        }
    }
}
