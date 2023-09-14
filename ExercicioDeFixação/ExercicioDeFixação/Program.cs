﻿using System;
using System.Globalization;
namespace exercicio
{
   class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"{produto1}, cujo preço é $ {preco1.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Registro:{idade} anos de idade, código {codigo} e gênero {genero} ");
            Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            Console.WriteLine($"Arredondado: {medida:F3}");
            Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}