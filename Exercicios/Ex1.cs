using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios {
    internal class Ex1 {
        public static void Executar() {
            /*
            Console.WriteLine("Nome do Jogador");
            string NomedoJogador = Console.ReadLine();
            Console.WriteLine("Numero da camisa");
            int NumerodaCamisa = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do Jogador");
            int IdadedoJogador = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome :"+NomedoJogador);
            Console.WriteLine ("Numero :"+NumerodaCamisa);
            Console.WriteLine("idade :"+IdadedoJogador);
            */



            /* Console.WriteLine("Quantidade de Gol no Primeiro Jogo" );
             double quantidade1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Quantidade de Gol no Segundo Jogo ");
             double quantidade2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Quantidade de Gol no terceiro Jogo ");
             double quantidade3 = int.Parse(Console.ReadLine());
             Console.WriteLine("total");
             double total = quantidade1 + quantidade2 + quantidade3;
             Console.WriteLine("resposta: "+total); */

            Console.WriteLine("Nome do torcedor");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantidade de ingresso");
            int ingresso = int.Parse(Console.ReadLine());
            int resultado = ingresso *150; int.Parse(Console.ReadLine());
            Console.WriteLine("Resposta: "+ resultado);




        }
    }
}
