using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Exercicios;
namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //{"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Exercicio1- Fundamentos",Exercicio1.Executar },
                {"Operadores Aritmeticos - fundamentos",OperadoresAritmeticos.Executar  },
                //Estrutura de Controle 
                { "Estrutura de controle",EstruturaIf.Executar },

                //Exercicios 
                {"Exercícios da vivi",Ex1.Executar },
                {"Estrutura Switch - Estrutura de Controle",EstruturaSwitch.Executar },
                {"Estrura de repetição",EstruturaDeRepeticao.Executar },
                
            
            });

            central.SelecionarEExecutar();
        }
    }
}
