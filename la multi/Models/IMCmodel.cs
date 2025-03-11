using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_multi.Models
{
    public class IMCModel
    {
        public double Altura { get; set; }
        public double Peso { get; set; }

        public double CalcularIMC()
        {
            if (Peso == 0) return 0;
            return Peso / (Altura * Altura);
        }

        public string GetResultadoIMC(double imc)
        {
            if (imc < 18.5)
                return "Bajo Peso";
            else if (imc >= 18.5 && imc < 24.9)
                return "Peso Normal";
            else if (imc >= 25 && imc < 29.9)
                return "Sobrepeso";
            else
                return "Obesidad";
        }
    }
}
