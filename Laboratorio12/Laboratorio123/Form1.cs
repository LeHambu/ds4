using static System.Windows.Forms.MonthCalendar;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSemiPeri_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtBoxA.Text);
            double ladoB = double.Parse(txtBoxB.Text);
            double ladoC = double.Parse(txtBoxC.Text);


            double semiperimetro = (ladoA + ladoB + ladoC) / 2;


            txtBoxSemP.Text = semiperimetro.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtBoxA.Text);
            double ladoB = double.Parse(txtBoxB.Text);
            double ladoC = double.Parse(txtBoxC.Text);


            double semiperimetro = (ladoA + ladoB + ladoC) / 2;


            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));


            txtBoxArea.Text = area.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxA.Text = "";
            txtBoxB.Text = "";
            txtBoxC.Text = "";
            txtBoxSemP.Text = "";
            txtBoxArea.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
