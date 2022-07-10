using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClasse_Dollar
{
     class ConversorDeMoeda
    {
        public static double ValorDolares;
        public static double Cotacao;
        public static double Iof = 6.0;

        public static double CalculaValorReais()
        {
            double valor_reais = ((ValorDolares * Cotacao));

            double total_pago_reais = valor_reais + (valor_reais * Iof) / 100;

            return total_pago_reais;
        }

        public static void RecebeValores(double dolares, double cotacao)
        {
            Cotacao = cotacao;
            ValorDolares = dolares;
        } 
    }
}
