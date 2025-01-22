using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Uri {
    class Uri36 {
        //bhaskara
        //ler 3 valores double
        // caso tenha alguma div com 0 ou num negativo mostre "impossivel de calcular"
        // dois resultados
        // x = -b +- sqrt(pow(b,2)-4*a*c) / 2*a
        //f5
        public static void Executar() {
            double A, B, C, R1, R2, delta, raiz;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //R1 = -B + Math.Sqrt((Math.Pow(B, 2)) - 4 * A * C)/ 2*A;
            //R2 = -B - Math.Sqrt((Math.Pow(B, 2)) - 4 * A * C)/ 2*A;

            delta = Math.Pow(B, 2) - 4 * A * C;

            if (A == 0 || delta < 0) {
                Console.WriteLine("Impossivel de calcular");
            }
            else {
                raiz = Math.Sqrt(delta);
                R1 = (-B + raiz) / (2 * A);
                R2 = (-B - raiz) / (2 * A);
                Console.WriteLine($"R1 = {R1.ToString("f5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("f5", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
