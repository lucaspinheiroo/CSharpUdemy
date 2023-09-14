using System;
using System.Globalization;
    class Program
{
    static void Main(string[] args)
    {
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";
        Console.WriteLine("{0} tem {1} anos e tem saldo de {2:F2} reais", nome, idade, saldo);
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais");
        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

    }
}