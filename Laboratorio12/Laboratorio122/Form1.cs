namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = double.Parse(txtBoxNo1.Text);
                double nota2 = double.Parse(txtBoxNo2.Text);
                double nota3 = double.Parse(txtBoxNo3.Text);
                double promedio = (nota1 + nota2 + nota3) / 3;
                txtBoxNotaP.Text = promedio.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese notas válidas.");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxNo1.Clear();
            txtBoxNo2.Clear();
            txtBoxNo3.Clear();
            txtBoxNotaP.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
