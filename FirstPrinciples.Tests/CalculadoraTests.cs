using FirstPrinciples.Console.Features;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrinciples.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora calculadora;

        public CalculadoraTests()
        {
            calculadora = new Calculadora();
        }

        int numero = 5;

        [Fact]
        public void Prueba_Sumar()
        {
            //Arrange 
            int num2 = 5;

            //Act
            numero = calculadora.Sumar(numero, num2);

            //Assert

            numero.Should().Be(10);
        }

        [Fact]
        public void Prueba_Restar()
        {
            //Arrange 
            int num2 = 5;

            //Act
            numero = calculadora.Restar(numero, num2);

            //Assert

            numero.Should().Be(0);
        }

        [Fact]
        public void Prueba_Multiplicar()
        {
            //Arrange 
            int num2 = 5;

            //Act
            numero = calculadora.Multiplicar(numero, num2);

            //Assert

            numero.Should().Be(25);
        }

        [Fact]
        public void Prueba_Dividir()
        {
            //Arrange 
            int num2 = 5;

            //Act
            numero = calculadora.Dividir(numero, num2);

            //Assert

            numero.Should().Be(1);
        }
    }
}
