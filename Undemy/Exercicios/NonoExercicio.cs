using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Undemy.Exercicios {
    class NonoExercicio {
        public static void Executar() {
            int x = int.Parse(Console.ReadLine());

            switch (x) {
                case 1:
                    Console.WriteLine("segunda!");
                    break;
                case 2:
                    Console.WriteLine("terca!");
                    break;
                case 3:
                    Console.WriteLine("quarta!");
                    break;
                case 4:
                    Console.WriteLine("quinta!");
                    break;
                case 5:
                    Console.WriteLine("sexta!");
                    break;
                case 6:
                    Console.WriteLine("sabado!");
                    break;
                case 7:
                    Console.WriteLine("domingo!");
                    break;
                default:
                    Console.WriteLine("Erro");
                    break;
            }
        }
    }
}
