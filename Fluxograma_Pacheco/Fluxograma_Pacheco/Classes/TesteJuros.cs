using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxograma_Pacheco.Classes
{
    public class TesteJuros
    {
        public double Juros(double valorInvestido, double meses)
        {
            double potenciaTaxaTempo = Math.Pow(1 + 0.07, meses / 12);
            double retornarJurosAcumulado = valorInvestido * potenciaTaxaTempo;

            return retornarJurosAcumulado - valorInvestido;
        }
    }
}
