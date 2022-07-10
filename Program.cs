using System;

namespace ExercicioClasse_Dollar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a cotação do dólar:");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em dólar a ser comprado:");
            double dolar = double.Parse(Console.ReadLine());

            ConversorDeMoeda.RecebeValores(dolar, cotacao);

            ConversorDeMoeda.CalculaValorReais();

            Console.WriteLine($"Cotação:{ConversorDeMoeda.Cotacao.ToString("F2")} \nCompra em Dólar: " +
                $"{ConversorDeMoeda.ValorDolares.ToString("F2")}" +
                $"\nTotal a ser pago em Reais: {ConversorDeMoeda.CalculaValorReais().ToString("F2")}");

        }
    }
}
