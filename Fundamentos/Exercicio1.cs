using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Exercicio1 {
        public static void Executar() {
            Console.WriteLine("Digite o nome do jogador: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do jogador: ");
            int idade= int.Parse(Console.ReadLine());

            Console.WriteLine("Solicite o numero da camisa");
            int numero= int.Parse(Console.ReadLine());

            Console.WriteLine("Solicitar o salário mensal do jogador");
            int salMensal = int.Parse(Console.ReadLine());

            Console.WriteLine("Solicitar a quantidades de gol marcado na temporada");
            int golMarcado = int.Parse(Console.ReadLine());

            Console.WriteLine("Solicitar o Ano de nascimento");
            DateOnly anodeNascimento = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade maxima de jogador");
            const int quantidadeJogadores = 26;

            Console.WriteLine($"Seu nome é {nome},Sua idade é {idade},seu numero é {numero},solicite salário mensal{salMensal},quantide de Gol marcado{golMarcado},solicitar ano de nascimento{anodeNascimento},Quantidade máxima de jogares{quantidadeJogadores}");




        }
    }
}
