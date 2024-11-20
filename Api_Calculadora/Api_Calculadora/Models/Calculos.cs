using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Calculadora.Models
{
    public class Calculos
    {
        public int Id { get; set; }
        public string Num1 { get; set; }
        public string Operador { get; set; }
        public string Num2 { get; set; }
        public double Resultado { get; set; }

    }
}