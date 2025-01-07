using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Fist
{
    class SegundoExercicio
    {
        public static void Executar()
        {
            double x = 10.35784;
            int y = 32;
            char z = 'F';
            string n = "Maria";

            Console.Write("Ola mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Ate mais.\n");

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("f2"));
            Console.WriteLine(x.ToString("f4"));
            Console.WriteLine(x.ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine($"\nResultado = {x}");
            Console.WriteLine($"O valor do troco é {x} reais");
            Console.WriteLine($"O valor do troco é {x.ToString("f2")} reais\n");

            Console.WriteLine($"A paciente {n} tem {y} anos e seu sexo é: {z}\n");

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);
            Console.WriteLine();

            double res;
            int p, s;

            p = 5;
            s = 2;
            res = (double) p / s;

            Console.WriteLine(res);
            Console.WriteLine();

            double f;
            int t;

            f = 5.0;
            b = (int)f;

            Console.WriteLine(f);
        }
    }
}
