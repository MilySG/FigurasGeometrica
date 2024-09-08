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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            FormRect formRect = new FormRect();
            formRect.ShowDialog();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            FormCirculo formCirculo = new FormCirculo();
            formCirculo.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo formTriangulo = new FormTriangulo();
            formTriangulo.ShowDialog();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            FormCuadrado formCuadrado = new FormCuadrado();
            formCuadrado.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
