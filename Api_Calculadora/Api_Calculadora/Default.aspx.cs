using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web;

namespace Api_Calculadora
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected async void btnGetApiData_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {

                    client.BaseAddress = new Uri("https://localhost:44371/"); 
                    var response = await client.GetAsync("api/Calculos");
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var calculos = JsonConvert.DeserializeObject<List<Calculo>>(content);
                        gvApiData.DataSource = calculos;
                        gvApiData.DataBind();
                    }
                    else
                    {
                        // Handle error
                        ScriptManager.RegisterStartupScript(this, GetType(), "apiError", "alert('Error al obtener datos de la API.');", true);
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception and show a user-friendly message
                    ScriptManager.RegisterStartupScript(this, GetType(), "apiError", $"alert('Error: {ex.Message}');", true);
                }
            }
        }
    }

    public class Calculo
    {
        public int Id { get; set; }
        public double Num1 { get; set; }
        public string Operador { get; set; }
        public double Num2 { get; set; }
        public double Resultado { get; set; }
    }
}