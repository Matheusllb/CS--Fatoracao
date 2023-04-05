using System;

namespace CsE22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 22
            Console.WriteLine("Calculando em fatoração\n\nInforme um valor:");
            int N = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= N; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
