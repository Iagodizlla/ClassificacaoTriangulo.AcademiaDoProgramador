
namespace ClassidicacaoTriangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string tipo;

                Cabecalho();
                string op = ExibirMenu();

                if (op == "1")
                {
                    var (lado1, lado2, lado3) = DadosDosLados();
                    ExibirDados(lado1, lado2, lado3);

                    if (VerificarTipo.TrianguloValido(lado1, lado2, lado3))
                    {
                        if (ClassificadorDeTriangulo.TrianguloEquilatero(lado1, lado2, lado3))
                        {
                            tipo = "Equilatero";
                        }
                        else if (ClassificadorDeTriangulo.TrianguloIsosceles(lado1, lado2, lado3))
                        {
                            tipo = "Isósceles";
                        }
                        else
                        {
                            tipo = "Escaleno";
                        }
                    }
                    else
                    {
                        VerificarTipo.TrianguloInvalido();
                        continue;
                    }
                    Resultado(tipo);
                }
                else if (op == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
                Console.ReadLine();
            }
        }
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("________________________________");
            Console.WriteLine("Classificação de Triângulos");
            Console.WriteLine("--------------------------------");
        }
        static string ExibirMenu()
        {
            Console.WriteLine("1 - Classificar Triangulo\n2 - Sair");
            Console.WriteLine("--------------------------------");
            string op = Console.ReadLine()!;
            return op;
        }
        static void ExibirDados(double lado1, double lado2, double lado3)
        {
            Cabecalho();
            Console.WriteLine($"Lado 1: {lado1}");
            Console.WriteLine($"Lado 2: {lado2}");
            Console.WriteLine($"Lado 3: {lado3}");
            Console.WriteLine("--------------------------------");
        }
        static (double, double, double) DadosDosLados()
        {
            double lado1, lado2, lado3;
            while (true)
            {
                Cabecalho();
                Console.Write("\nDigite o valor do lado 1: ");
                bool l1 = double.TryParse(Console.ReadLine()!, out double j);

                Console.Write("Digite o valor do lado 2: ");
                bool l2 = double.TryParse(Console.ReadLine()!, out double l);

                Console.Write("Digite o valor do lado 3: ");
                bool l3 = double.TryParse(Console.ReadLine()!, out double i);

                if (l1 == false){
                    Console.WriteLine("lado 1 é invalido!");
                }
                else if (l2 == false){
                    Console.WriteLine("lado 2 é invalido!");
                }
                else if (l3 == false){
                    Console.WriteLine("lado 3 é invalido!");
                }
                else{
                    lado1 = j;
                    lado2 = l;
                    lado3 = i;
                    break;
                }
                Console.ReadLine();
            }
            return (lado1, lado2, lado3);

        }
        static void Resultado(string tipo)
        {
            Console.WriteLine($"Triangulo do tipo: {tipo}");
            switch(tipo){
                case "Equilatero":
                    TrianguloGeometrico.GeoEquilatero();
                    break;
                case "Isósceles":
                    TrianguloGeometrico.GeoIsosceles();
                    break;
                case "Escaleno":
                    TrianguloGeometrico.GeoEscaleno();
                    break;
            }
        }
    }
}