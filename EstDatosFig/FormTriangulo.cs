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
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseTri) && double.TryParse(txtAltura.Text, out double altura))
            {
                double area = (baseTri * altura) / 2;

                if (double.TryParse(txtLado1.Text, out double lado1) &&
                    double.TryParse(txtLado2.Text, out double lado2) &&
                    double.TryParse(txtLado3.Text, out double lado3))
                {
                    double perimetro = lado1 + lado2 + lado3;
                    lblArea.Text = $"Área: {area}";
                    lblPerimetro.Text = $"Perímetro: {perimetro}";
                }
                else
                {
                    MessageBox.Show("Por favor ingrese los lados correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese la base y la altura correctamente.");
            }
        }
    }
}
