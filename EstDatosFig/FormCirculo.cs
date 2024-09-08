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
    public partial class FormCirculo : Form
    {
        public FormCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                double area = Math.PI * radio * radio;
                double perimetro = 2 * Math.PI * radio;

                lblArea.Text = $"Área: {area}";
                lblPerimetro.Text = $"Perímetro: {perimetro}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor válido.");
            }
        }

        private void FormCirculo_Load(object sender, EventArgs e)
        {

        }
    }
}
