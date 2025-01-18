using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Fist {
    class AttQui {
        //se a soma das notas forem < que 60.00 "escrevera errado" 
        public static void Executar() {

            float n1, n2, soma;

            n1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = n1 + n2;

            if (soma > 60.00) {
                Console.WriteLine($"NOTA FINAL = {soma.ToString(CultureInfo.InvariantCulture)}");
            }
            else {
                Console.WriteLine($"NOTA FINAL = {soma.ToString(CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
