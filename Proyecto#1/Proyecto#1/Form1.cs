using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing.Printing;

namespace Proyecto_1
{
    public partial class Form1 : Form

    {
        double num1 = 0, num2 = 0;
        string operador = "";
        string connectionString = "Server=localhost;Database=Proyecto1;Trusted_Connection=True;TrustServerCertificate=True;";
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
            double resultado = 0;
            num2 = Convert.ToDouble(txtResultado.Text);
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        txtResultado.Text = "Error: División por cero";
                        return;
                    }
                    break;
                case "^":
                    resultado = Math.Pow(num1, num2);
                    break;
            }

            txtResultado.Text = resultado.ToString();

            GuardarCalculo(operador, resultado);
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

        private void btnMostrarCalculos_Click_1(object sender, EventArgs e)
        {
            listBoxCalculos.Items.Clear();
            string query = "SELECT * FROM Calculos";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos");
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Se encontraron registros");

                                while (reader.Read())
                                {
                                    double num1 = Convert.ToDouble(reader["Num1"]);
                                    string operador = reader["Operador"].ToString();
                                    double num2 = Convert.ToDouble(reader["Num2"]);
                                    double resultado = Convert.ToDouble(reader["Resultado"]);

                                    string calculo = $"{num1} {operador} {num2} = {resultado}";

                                    listBoxCalculos.Items.Add(calculo);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros en la tabla");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}