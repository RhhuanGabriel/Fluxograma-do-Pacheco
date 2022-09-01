using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxograma_Pacheco.Classes
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public double capital { get; set; }

        public static double mediaIdade(List<Cliente> clientes)
        {
            double soma = 0;
            foreach(var item in clientes)
            {
                soma = soma + item.idade;
            }
            double media = soma / clientes.Count();
            return Math.Round(media, 2);
        }
    }
}
