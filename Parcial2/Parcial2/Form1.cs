using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        private List<string> historial = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnLbsKg_Click(object sender, EventArgs e)
        {
            try
            {
                double libras = Convert.ToDouble(txtLibras.Text);
                double kilogramos = libras / 2.2046;
                txtResultadoKg.Text = $"{libras} libras = {kilogramos:F2} kg";


                historial.Add($"{libras} libras = {kilogramos:F2} kg");
                ActualizarHistorial();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void btnKgLbs_Click(object sender, EventArgs e)
        {
            try
            {
                double kilogramos = Convert.ToDouble(txtKg.Text);
                double libras = kilogramos * 2.2046;
                txtResultadoLbs.Text = $"{kilogramos} kg = {libras:F2} libras";


                historial.Add($"{kilogramos} kg = {libras:F2} libras");
                ActualizarHistorial();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }
        private void ActualizarHistorial()
        {
            lstHistorial.Items.Clear();
            foreach (var registro in historial)
            {
                lstHistorial.Items.Add(registro);
            }
        }

    }
}
