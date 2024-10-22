using System;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form

    {
        double num1 = 0, num2 = 0;
        string operador = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para los botones de los números
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;  // Añade el número presionado al TextBox
        }

        // Evento para los botones de operación (+, -, *, /)
        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);  // Almacena el primer número
            operador = boton.Text;  // Guarda el operador seleccionado (+, -, *, /)
            txtResultado.Text = "";  // Limpia el TextBox para el segundo número
        }

        // Evento para el botón de igual
        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);  // Captura el segundo número

            // Realiza la operación correspondiente
            switch (operador)
            {
                case "+":
                    txtResultado.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtResultado.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtResultado.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                        txtResultado.Text = (num1 / num2).ToString();
                    else
                        txtResultado.Text = "Error: División por cero";
                    break;
                case "^":  // Potencia (exponente)
                    double resultado = Math.Pow(num1, num2);
                    txtResultado.Text = resultado.ToString();
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);  // Almacena el primer número
            operador = boton.Text;  // Guarda el operador seleccionado (+, -, *, /)
            txtResultado.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);  // Almacena el primer número
            operador = boton.Text;  // Guarda el operador seleccionado (+, -, *, /)
            txtResultado.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);  // Almacena el primer número
            operador = boton.Text;  // Guarda el operador seleccionado (+, -, *, /)
            txtResultado.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);  // Almacena el primer número
            operador = boton.Text;  // Guarda el operador seleccionado (+, -, *, /)
            txtResultado.Text = "";
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);  // Almacena el primer número
            operador = boton.Text;  // Guarda el operador seleccionado (+, -, *, /)
            txtResultado.Text = "";
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
        
            try
            {
                double num = Convert.ToDouble(txtResultado.Text);
                if (num >= 0)
                {
                    double resultado = Math.Sqrt(num);
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    txtResultado.Text = "Error: No existe raíz cuadrada de número negativo.";
                }
            }
            catch (FormatException)
            {
                txtResultado.Text = "Error: Entrada no válida.";
            }

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtResultado.Clear();  // Limpia el TextBox
            num1 = 0;
            num2 = 0;
            operador = "";
        }
    }


}

