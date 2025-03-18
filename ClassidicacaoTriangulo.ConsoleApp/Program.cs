﻿namespace ClassidicacaoTriangulo.ConsoleApp
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
                    Cabecalho();
                    var (lado1, lado2, lado3) = DadosDosLados();

                    if (TrianguloValido(lado1, lado2, lado3))
                    {
                        if (TranguloEquilatero(lado1, lado2, lado3))
                        {
                            tipo = "Equilatero";
                        }
                        else if (TranguloIsosceles(lado1, lado2, lado3))
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
                        TrianguloInvalido();
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
        static (double, double, double) DadosDosLados()
        {
            Console.Write("\nDigite o valor do lado 1: ");
            double lado1 = double.Parse(Console.ReadLine()!);
            Console.Write("Digite o valor do lado 2: ");
            double lado2 = double.Parse(Console.ReadLine()!);
            Console.Write("Digite o valor do lado 3: ");
            double lado3 = double.Parse(Console.ReadLine()!);
            return (lado1, lado2, lado3);
        }
        static bool TrianguloValido(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
        }
        static bool TranguloEquilatero(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 && lado2 == lado3;
        }
        static bool TranguloIsosceles(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 || lado2 == lado3 || lado1 == lado3;
        }
        static void TrianguloInvalido()
        {
            Console.WriteLine("Não é um triângulo!");
            Console.ReadLine();
        }
        static void Resultado(string tipo)
        {
            Console.WriteLine($"Triangulo do tipo: {tipo}");
        }
    }
}