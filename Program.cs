using System;

namespace projetinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                for (int i = numero; i <= numero + 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Erro! Tente novamente.");
            }
        }
    }
}