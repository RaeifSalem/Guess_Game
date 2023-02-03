using System;

namespace Jogo_de_adivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero_aleatorio = random.Next(1, 101);
            int Acerto;

            Console.WriteLine("Adivinhe o número entre 1 e 100");
            do
            {
                Acerto = int.Parse(Console.ReadLine());
                if (Acerto < numero_aleatorio)
                {
                    Console.WriteLine("O número é maior. Tente novamente");

                }
                else if (Acerto > numero_aleatorio)
                {
                    Console.WriteLine("O número é menor. Tente novamente");
                }
            } while (Acerto != numero_aleatorio);
            Console.WriteLine("Parabéns, você adivinhou o número.");
            Console.ReadLine();
        }
    }
}