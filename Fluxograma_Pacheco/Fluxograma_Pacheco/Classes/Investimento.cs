using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxograma_Pacheco.Classes
{
    public class Investimento
    {
        public double valorInvestido { get; set; }
        public double meses { get; set; }
        public List<Cliente> cliente { get; set; }

        public double retornarJurosAcumulado(List<Cliente> cliente, int meses)
        {
            return 0;
        }

        public double retornarJurosCliente(Cliente cliente, double meses)
        {
            double potenciaTaxaTempo = Math.Pow(1 + 0.07, meses / 12);
            double retornarJurosAcumulado = cliente.capital * potenciaTaxaTempo;
            double juros = retornarJurosAcumulado - cliente.capital;

            return Math.Round(juros, 2);
        }
    }
}
