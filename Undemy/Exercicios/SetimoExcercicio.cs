using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Undemy.Exercicios {
    class SetimoExcercicio {
        public static void Executar() {
            int n1, n2, n3;
            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            n3 = int.Parse(vet[2]);

            if (n1 < n2 && n1 < n3) {
                Console.WriteLine(n1);
            }
            else if (n2 < n3) {
                Console.WriteLine(n2);
            }
            else {
                Console.WriteLine(n3);
            }
        }
    }
}
