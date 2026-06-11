using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {

            /*Console.WriteLine("Escolha uma seleção: ");
            Console.WriteLine("1-Brasil");
            Console.WriteLine("2-Argentina");
            Console.WriteLine("3-França");
            Console.WriteLine("4-Japão");
            Console.WriteLine("5-Panamá");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao) {
                case 1:
                    Console.WriteLine("Canarinho");
                    break;
                case 2:
                    Console.WriteLine("Gauchito");
                    break;
                case 3:
                    Console.WriteLine("Galo Gaulês");
                    break;
                case 4:
                    Console.WriteLine("Yatagarasu");
                    break;
                case 5:
                    Console.WriteLine("Gabriel Andrade");
                    break;
            */



                    Console.WriteLine("Quantos jogos deseja registrar?"); int quantidadeJogos = int.Parse(Console.ReadLine()); int totalGols = 0; for (int i = 1; i <= quantidadeJogos; i++) {
                        Console.WriteLine("Foram feitos quantos gols?");
                        int gols = int.Parse(Console.ReadLine());
                        Console.WriteLine($"No jogo {i}, foram feitos {gols} gols.");
                        totalGols = totalGols + gols;
                        if (i == quantidadeJogos) {
                            Console.WriteLine($"Total de gols: {totalGols}");
                        }






                    }

        }


    }

}



