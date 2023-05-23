using System;
using System.Globalization;

namespace DadosBancarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            DadosConta conta;           

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (S/N) ? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S' || resposta == 's')
            {
                Console.Write("Digite o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new DadosConta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new DadosConta(numero, titular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta: ");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            System.Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
        }
    }
}