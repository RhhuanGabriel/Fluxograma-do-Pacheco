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
        public List<Cliente> clientes { get; set; }

        public double retornarJurosCliente(Cliente clientes, double meses)
        {
            double montante = clientes.capital * (Math.Pow(1 + 0.07, meses / 12));
            return montante - clientes.capital;

            montante = clientes.capital * (Math.Pow(1 + 0.07, meses / 12));
            double juros = montante - clientes.capital;

            return Math.Round(juros, 2);
        }

        public double retornarJurosAcumulado(List<Cliente> cliente, int meses)
        {
            double jurosAcumulado = 0;
            foreach (var item in cliente)
            {
                jurosAcumulado = jurosAcumulado + retornarJurosCliente(item, 24);
            }
            return jurosAcumulado;
        }
    }
}
