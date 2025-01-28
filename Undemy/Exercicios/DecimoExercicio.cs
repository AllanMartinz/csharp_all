using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Undemy.Exercicios {
    class DecimoExercicio {
        public static void Executar() {
            int x, soma; 

            x = int.Parse(Console.ReadLine());
            soma = 0;
            // o while sempre ira repetir o que estiver dentro do laço dele ate que seja false
            while (x != 0) { //uso do desigual // caso nao for 0 Ira repetir o laço
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            } // caso seja false saira do laço e vai para a proxima linha
            Console.WriteLine(soma);
        }
    }
}
