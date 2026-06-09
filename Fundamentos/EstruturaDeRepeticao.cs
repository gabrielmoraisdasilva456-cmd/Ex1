using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class EstruturaDeRepeticao {
        public static void Executar() {
            int contador = 1;

            while (contador <= 10) {
                Console.WriteLine(contador);
                contador++;

            }

            for (int cont = 1; cont <= 10; cont++) {
                Console.WriteLine(cont);

               

            }

            Console.WriteLine("Digite a quantidade de torcedores:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++) {
                Console.WriteLine($"Torcedor {i} entrou no estádio");

            }


        } 

    }
}
