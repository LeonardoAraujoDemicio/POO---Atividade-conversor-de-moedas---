using System;
using System.Globalization;

namespace Conversor_de_moedas_Léo
{
    class Program
    {
        static void Main(string[] args)
        {
            // criação de variável para a cotação do dólar.
            Console.WriteLine("Qual é a cotação do dólar: ");
            double cota = double.Parse(Console.ReadLine());

            // criação de variável para declaração da quantidade de dólares a serem comprados.
            Console.WriteLine("Quantos dólares você irá comprar: ");
            double comprar = double.Parse(Console.ReadLine());

            // criação de variáveis para descrição do preço da compra de dólar em reais.
            double preco; 
            preco = cota * comprar;
            Console.WriteLine("Valor a ser pago em reais: " + preco);

            Console.ReadKey();

            // para sair os valores desejados, use a virgula na declaração das variaveis ao invés do ponto
            // por algum motivo, meu programa só entende a virgula, e não o ponto
        }
    }
}
