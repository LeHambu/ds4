using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;

namespace Proyecto_1
{
    public partial class Form1 : Form

    {
        double num1 = 0, num2 = 0;
        string operador = "";
        string connectionString = "Server=localhost;Database=Proyecto1;Trusted_Connection=True;";
        bool nuevaOperacion;
        string textoImprimir = "";

        public Form1()
        {
            InitializeComponent();
            nuevaOperacion = false;
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtResultado.Text += boton.Text;
        }


        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;
            txtResultado.Text = "";
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);
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
                case "^":
                    double resultado = Math.Pow(num1, num2);
                    txtResultado.Text = resultado.ToString();
                    break;

            }
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("Por favor ingresa un número válido");
                return;
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
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;
            txtResultado.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;
            txtResultado.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;
            txtResultado.Text = "";
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = boton.Text;
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
            txtResultado.Clear();
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnMostrarCalculos_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Calculos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show($"Num1: {reader["Num1"]}, Operador: {reader["Operador"]}, Num2: {reader["Num2"]}, Resultado: {reader["Resultado"]}");
                }
            }
        }
        private void GuardarCalculo(string operador, double resultado)
        {
            string query = "INSERT INTO Calculos (Num1, Operador, Num2, Resultado) VALUES (@Num1, @Operador, @Num2, @Resultado)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Num1", num1);
                command.Parameters.AddWithValue("@Operador", operador);
                command.Parameters.AddWithValue("@Num2", num2);
                command.Parameters.AddWithValue("@Resultado", resultado);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    

    
}

