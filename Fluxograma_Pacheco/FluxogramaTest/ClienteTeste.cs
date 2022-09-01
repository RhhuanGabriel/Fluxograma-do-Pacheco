using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluxograma_Pacheco.Classes;

namespace FluxogramaTest
{
    [TestClass]
    public class ClienteTeste
    {
        [TestMethod]
        public void mediaDeIdade()
        {
            double esperado = 31.67;
            double resultado = 0;

            Cliente cli01 = new Cliente();
            cli01.idade = 33;

            Cliente cli02 = new Cliente();
            cli02.idade = 25;

            Cliente cli03 = new Cliente();
            cli03.idade = 37;

            List<Cliente> lista = new List<Cliente>();

            lista.Add(cli01);
            lista.Add(cli02);
            lista.Add(cli03);

            resultado = Cliente.mediaIdade(lista);
            Assert.AreEqual(esperado, resultado);
        }
    }
}
