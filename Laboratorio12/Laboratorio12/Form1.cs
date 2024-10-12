namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(txtVel.Text);
                double tiempo = Convert.ToDouble(txtTiempo.Text);
                double distancia = velocidad * tiempo;

                textBoxResultado.Text = distancia.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }

        }

        private void txtVel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVel.Clear();
            txtTiempo.Clear();
            textBoxResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
