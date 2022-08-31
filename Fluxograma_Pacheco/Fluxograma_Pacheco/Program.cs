using System;
using System.Collections.Generic;
using Fluxograma_Pacheco.Classes;

namespace Fluxograma_Pacheco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Investimento> investimento = new List<Investimento>();

            double valorInvestido, retornarJurosAcumulado, potenciaTaxaTempo, meses, anos, juros, media;
            string nome;
            int idade, quantidade, contagem = clientes.Count;

            Console.Write("Quantos clientes desejam fazer investimento? (Máximo dois clientes): ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            while(quantidade > 2)
            {
                Console.Write("Você digitou um valor acima de 2, digite novamente: ");
                quantidade = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= quantidade; i++)
            {
                Console.Write("Digite o nome do cliente: ");
                nome = Console.ReadLine();

                Console.Write("Digite a idade do cliente: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor a ser investido: ");
                valorInvestido = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantos meses será acumulado?: ");
                meses = Convert.ToInt32(Console.ReadLine());

                clientes.Add(new Cliente() { nome = nome, idade = idade});
            }

            // anos = meses / 12;
            // potenciaTaxaTempo = Math.Pow(1 + 0.07, anos);
            // juros = retornarJurosAcumulado - valorInvestido;
            // retornarJurosAcumulado = valorInvestido * potenciaTaxaTempo;

            // Console.WriteLine("O valor final da transação é: R$" + retornarJurosAcumulado);
            // Console.WriteLine("Juros: R$" + juros);
        }
    }
}