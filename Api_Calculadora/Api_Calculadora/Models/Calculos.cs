using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Api_Calculadora.Models
{
    public class Calculo
    {
        [Key]
        public int Id { get; set; }
        public double? Num1 { get; set; }
        public string Operador { get; set; }
        public double? Num2 { get; set; }
        public double? Resultado { get; set; }
    }
}