using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Digite o seu CVV?");
            int codigo = int.Parse (Console .ReadLine());

            Console.WriteLine("O cvv do seu cartão é ",codigo);



            // formatando números 

            double valor = 67.67676767;

            // Arredondar numeros 
            Console.WriteLine(valor.ToString("f1"));
            // Valor monetário 
            Console.WriteLine(valor.ToString("C"));
            // Formatando do jeito que você quer 
            Console.WriteLine(valor.ToString("#.###"));
            // Porcentagem 
            Console.WriteLine(valor.ToString("P"));
       }
    }
}
