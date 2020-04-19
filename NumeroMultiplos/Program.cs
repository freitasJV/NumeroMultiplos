using System;

namespace NumerosMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros A e B na sequência, separados por espaço. Exemplo 20 2");
            string[] entrada = Console.ReadLine().Split(' ');

            int A = int.Parse(entrada[0]);
            int B = int.Parse(entrada[1]);

            if ((A > B && A % B == 0) | (A < B && B % A == 0))
                Console.WriteLine("São múltiplos");
            else
                Console.WriteLine("Não São múltiplos");
        }
    }
}
