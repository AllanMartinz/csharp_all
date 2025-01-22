using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Exercicios
{
    class QuartoExercicio
    {
        public static void Executar()
        {
            // uso do parse par coverter um valor da var
            int n1 = int.Parse(Console.ReadLine()); //a string do Readline sera pasade para int
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
