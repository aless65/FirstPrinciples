using FirstPrinciples.Console.Features;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;


namespace FirstPrinciples.Tests
{
    public class ConversorDeMonedaTests
    {
        [Fact]
        public void ConversorDeMonedas_Test()
        {
            var conversorDeMoneda = Substitute.For<ConversorDeMoneda>();

            decimal cantidad = 100;
            string monedaOrigen = "USD";
            string monedaDestino = "HNL";

            conversorDeMoneda.Convertir(cantidad, monedaOrigen, monedaDestino).Returns(2465.28m);

            decimal resultado = conversorDeMoneda.Convertir(cantidad, monedaOrigen, monedaDestino);

            resultado.Should().Be(2465.28m);
        }
    }
}
