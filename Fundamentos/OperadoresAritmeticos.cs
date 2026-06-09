using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //Console.WriteLine("Digite um numero");
            //double n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite outro numero");
            //double n2 = double.Parse(Console.ReadLine());

            //double total = n1 + n2;
            //Console.WriteL
            /*
            Console.WriteLine("digite a base");
            double baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a altura");
            double altura = double.Parse(Console.ReadLine());
            //Console.WriteLine("dividido por dois");
            //int dividido = int.Parse(Console.ReadLine());
            //Console.WriteLine("area é (baset.altura)/2 ");
            double area = (baseT * altura) / 2;
            Console.WriteLine($"A altura do seu triangulo é de: {area}");
            */

            int a = 10;
            int b = 20;
            int c = 42;
            int d = 14;

            Console.WriteLine(c >= b);
            Console.WriteLine(d < b);
            Console.WriteLine(a == b && d <= b);
            // f e v =f 
            Console.WriteLine(a > d|| c != d);
            // f ou v = v       
        
        }

    }
}
