using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("                 JOGO DE DADOS");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.Write("Informe seu nome jogador 1: ");
            string jg1 = Console.ReadLine().ToUpper();
            Console.Write("Informe seu nome jogador 2: ");
            string jg2 = Console.ReadLine().ToUpper();

            //if pra não ter os nomes iguais
            if (jg1 == jg2)
            {
                Console.WriteLine("Os nomes não podem ser iguais..");
                Console.Write("Insira outro nome jogador 2: ");
                jg2 = Console.ReadLine();
            }

            Console.WriteLine();

            Console.Write("Insira a quantidade de rodadas do jogo (entre 3 e 5): ");
            int numeroDeRodadas = int.Parse(Console.ReadLine());

            Random random = new Random();
            int vitoriasJgd1 = 0;
            int vitoriasJgd2 = 0;

            for (int rodada = 1; rodada <= numeroDeRodadas; rodada++)
            {
                int resultJgd1 = random.Next(1, 7);
                int resultJgd2 = random.Next(1, 7);

                Console.WriteLine($"Resultado: {jg1}: {resultJgd1}, {jg2}: {resultJgd2}");

                if (resultJgd1 > resultJgd2)
                {
                    Console.WriteLine($"{jg1} Venceu a rodada!!");
                    vitoriasJgd1++;
                    Console.WriteLine();
                }
                else if (resultJgd1 < resultJgd2)
                {
                    Console.WriteLine($"{jg2} Venceu a rodada!!");
                    vitoriasJgd2++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A rodada empatou!!");
                    Console.WriteLine();
                }
               
            }
            Console.WriteLine($"Placar final: {jg1}: {vitoriasJgd1} || {jg2}: {vitoriasJgd2}");
            if (vitoriasJgd1 > vitoriasJgd2)
            {
                Console.WriteLine($"{jg1} VENCEU O JOGO!!");
            }
            else if (vitoriasJgd2 > vitoriasJgd1)
            {
                Console.WriteLine($"{jg2} VENCEU O JOGO!!");
            }
            else
            {
                Console.WriteLine("O JOGO EMPATOU!!");
            }
        }
    }
}
