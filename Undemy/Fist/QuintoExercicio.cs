using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Undemy.Fist
{
    class QuintoExercicio
    {
        public static void Executar()
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0; 
            double A, B, C;

            A = Math.Sqrt(x); //Math para usa matematico - Sqrt raiz quadrada
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine($"Raiz qudrada de {x} = {A}");
            Console.WriteLine($"Raiz qudrada de {y} = {B}");
            Console.WriteLine($"Raiz qudrada de 25 = {C}");

            A = Math.Pow(x, y); // Pow potenciacao
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine($"{x} elevado a {y} = {A}");
            Console.WriteLine($"{x} elevado ao quadrado = {B}");
            Console.WriteLine($"5 elevado ao quadrado = {C}");

            A = Math.Abs(y); // Abs Absoluto
            B = Math.Abs(z);
            Console.WriteLine($"Valor absoluto de {y} = {A}");
            Console.WriteLine($"Valor absoluto de {z} = {B}");
        }
    }
}
