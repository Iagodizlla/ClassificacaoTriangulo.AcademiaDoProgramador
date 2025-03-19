using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassidicacaoTriangulo.ConsoleApp
{
    internal class TrianguloGeometrico
    {
        public static void GeoEquilatero()
        {
            Console.WriteLine("       /\\      ");
            Console.WriteLine("      /  \\     ");
            Console.WriteLine("     /    \\    ");
            Console.WriteLine("    /      \\   ");
            Console.WriteLine("   /        \\  ");
            Console.WriteLine("  /          \\ ");
            Console.WriteLine(" /____________\\");
        }
        public static void GeoIsosceles()
        {
            Console.WriteLine(" |\\_           ");
            Console.WriteLine(" |  \\_         ");
            Console.WriteLine(" |    \\_       ");
            Console.WriteLine(" |      \\_     ");
            Console.WriteLine(" |        \\_   ");
            Console.WriteLine(" |          \\_ ");
            Console.WriteLine(" |____________\\");
        }
        public static void GeoEscaleno()
        {
            Console.WriteLine("   |\\_           ");
            Console.WriteLine("  /   \\_         ");
            Console.WriteLine("  |     \\_       ");
            Console.WriteLine(" /        \\_     ");
            Console.WriteLine(" |          \\_   ");
            Console.WriteLine("/             \\_ ");
            Console.WriteLine("|_______________\\");
        }
        public static void GeoInvalido()
        {
            Console.WriteLine("                    _____  ");
            Console.WriteLine("|      /\\          /     \\");
            Console.WriteLine("|     /  \\                |");
            Console.WriteLine("|    /    \\              / ");
            Console.WriteLine("|   /      \\          ==/  ");
            Console.WriteLine("|  /        \\        ||    ");
            Console.WriteLine("| /          \\             ");
            Console.WriteLine("|/            \\      ()    ");
        }
    }
}