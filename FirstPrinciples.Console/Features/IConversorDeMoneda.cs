using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrinciples.Console.Features
{
    public interface IConversorDeMoneda
    {
        decimal Convertir(decimal cantidad, string monedaOrigen, string monedaDestino);
    }
}
