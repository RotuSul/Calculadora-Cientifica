using System;
using System.Threading;
using System.Globalization;

namespace Calculadora_Cientifica
{
    class Program
    {
        public double Denominador = 0;
        public double Numerador = 0;
        static void Main(string[] args)
        {


            Console.WriteLine("P - probabilidae de vim uma tentativa certas");
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("Criar um Valor para numerador");
            Console.Write("Colocar Valor Aqui : ");
            double numerador = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Criar um Valor para denominado");
            Console.Write("Colocar Valor Aqui : ");
            double denominador = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");

            double P = denominador / numerador;

            Console.WriteLine();
            Console.WriteLine("K - tentativas que deram errado");
            Console.WriteLine("------------------------------------------------------------------");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Q -probabilidae de vim uma tentativa errada");
            Console.Write("Iniciando");
            int Loop = 3;
            for (int i = 1; i <= Loop; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            double Q = P - 1;
            Console.WriteLine();
            Console.WriteLine("n - Total de Tentativas");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double DivisãoP = n / k;
            double Part1Elevator = Math.Pow(P, k);
            double Part2Elevator = Math.Pow(Q, n - k);
            double Result = DivisãoP * Part1Elevator * Part2Elevator;
            Result = Math.Round(Result, 3);
            Console.WriteLine("Seu Resulatdo Foi : " + Result);
        }

    }
    }

