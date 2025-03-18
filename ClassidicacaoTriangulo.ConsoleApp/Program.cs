namespace ClassidicacaoTriangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                string tipo;
                Console.Clear();
                Console.WriteLine("________________________________");
                Console.WriteLine("Classificação de Triângulos");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1 - Classificar Triangulo\n2 - Sair");
                Console.WriteLine("--------------------------------");
                string op = Console.ReadLine()!;

                if (op == "1")
                {
                    Console.Clear();
                    Console.WriteLine("________________________________");
                    Console.WriteLine("Classificação de Triângulos");
                    Console.WriteLine("--------------------------------\n");

                    Console.Write("Digite o valor do lado 1: ");
                    double lado1 = double.Parse(Console.ReadLine()!);
                    Console.Write("Digite o valor do lado 2: ");
                    double lado2 = double.Parse(Console.ReadLine()!);
                    Console.Write("Digite o valor do lado 3: ");
                    double lado3 = double.Parse(Console.ReadLine()!);

                    if(lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                    {
                        if (lado1 == lado2 && lado2 == lado3)
                        {
                            tipo = "Equilatero";
                        }
                        else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
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
                        Console.WriteLine("Não é um triângulo!");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine($"Triangulo do tipo: {tipo}");
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
    }
}
