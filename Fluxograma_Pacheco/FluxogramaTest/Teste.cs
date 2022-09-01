using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluxograma_Pacheco.Classes;
using System.Collections.Generic;

namespace FluxogramaTest
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void jurosDeUmClienteCorreto()
        {
            double esperado = 202.86;
            double resultado = 0;

            Cliente cliente = new Cliente();
            cliente.capital = 1400;

            Investimento invest = new Investimento();

            resultado = invest.retornarJurosCliente(cliente, 24);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void jurosDe3Clientes()
        {
            double esperado = 698.58;
            double resultado = 0;

            Cliente cliente1 = new Cliente();
            cliente1.capital = 1400;
            Cliente cliente2 = new Cliente();
            cliente2.capital = 1400;
            Cliente cliente3 = new Cliente();
            cliente3.capital = 1400;

            List<Cliente> lista = new List<Cliente>();

            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);

            Investimento invest= new Investimento();

            resultado = invest.retornarJurosCliente(lista, 24);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
