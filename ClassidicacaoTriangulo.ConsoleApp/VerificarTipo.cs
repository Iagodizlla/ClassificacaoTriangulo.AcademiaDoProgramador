using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassidicacaoTriangulo.ConsoleApp
{
    public class VerificarTipo
    {
        public static bool TrianguloValido(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
        }
        public static void TrianguloInvalido()
        {
            Console.WriteLine("Não é um triângulo!");
            TrianguloGeometrico.GeoInvalido();
            Console.ReadLine();
        }
    }
}
