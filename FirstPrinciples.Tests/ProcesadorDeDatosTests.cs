using FirstPrinciples.Console.Features;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace FirstPrinciples.Tests
{
    public class ProcesadorDeDatosTests
    {
        [Fact]
        public void Procesar_Transaccion_Ejecucion()
        {
            ProcesadorDeDatos procesadorDeDatos = new ProcesadorDeDatos();

            Action action = () => procesadorDeDatos.ProcesarTransaccion();

            action.ExecutionTime().Should().BeLessThanOrEqualTo(200.Milliseconds());
        }
    }
}