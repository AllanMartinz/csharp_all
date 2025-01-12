using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Undemy.Fist
{
    class TerceiroExercicio
    {
        public static void Executar()
        {
            //uso readline para escrever no console
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            // uso de arrays para criacoa de uma especie de lista para atribuir a ela
            string[] vet = Console.ReadLine().Split(' '); // split para separa quem e quem com um ' '
            // atribuir cada vetor com [] do primeiro 0 ao ultimo ...
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("vc digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

        }
    }
}
