using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class EstruturaDeRepeticao {
        public static void Executar() {
            /* int contador =1;

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
                 Console.WriteLine($"Torcedor {i} entrou no estádio");*/

            /*int contador = 1;
            int tentativas = 3;
            Console.WriteLine("Digite a senha");
            string password = Console.ReadLine();

            while (password != "7taz9Hvj" && contador != 3) {
                Console.WriteLine($"Senha invalida. Você tem {tentativas-contador}"+$"Digite a senha novamente ");
                password = Console.ReadLine();
                if (password == "7taz9Hvj") {
                    Console.WriteLine("Acesso permitido!");
                    break;
                } else {
                    Console.WriteLine("Acesso negado!");
                    contador++;
                
                }
            }*/





            /*int contador = 1;
            while (contador <= 10) {
                Console.WriteLine($"{contador}");
                contador++;

            
            }*/
        
           /* int contador = 10;
            while (contador >= 0) {
                Console.WriteLine($"{contador}");
                contador--;

            }*/

            int contador = 1;
            while (contador <= 3) {
                Console.WriteLine("Eu Gosto de programação");
                contador++;
            }




        }

    }
}
