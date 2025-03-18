using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassidicacaoTriangulo.ConsoleApp
{
    internal class ClassificadorDeTriangulo
    {
        public static bool TrianguloEquilatero(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 && lado2 == lado3;
        }
        public static bool TrianguloIsosceles(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 || lado2 == lado3 || lado1 == lado3;
        }
    }
}
