namespace EstDatosFig
{
    public partial class FormRect : Form
    {
        public FormRect()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (double.TryParse(txtLargo.Text, out double largo) && double.TryParse(txtAncho.Text, out double ancho))
            {
                double area = largo * ancho;
                double perimetro = 2 * (largo + ancho);

                lblArea.Text = $"Área: {area}";
                lblPerimetro.Text = $"Perímetro: {perimetro}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores válidos.");
            }
        }

        private void FormRect_Load(object sender, EventArgs e)
        {
            // Aquí podrías agregar alguna funcionalidad si es necesario cuando se cargue el formulario.
        }
    }
}
