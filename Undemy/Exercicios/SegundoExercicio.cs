using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // o uso de comps pemitira o uso de certos comandos

namespace CSharp_all.Undemy.Exercicios
{
    class SegundoExercicio
    {
        public static void Executar()
        {
            // declaração a variavel
            // apos declarar uma var precisa do nome dela e dependendo  = o valor dela
            double x = 10.35784; //double num com virgula || na unity se for usar usa se o float
            int y = 32; // int numero inteiro
            char z = 'F'; // char apenas um valor atribuida com 'aspas simples'
            string n = "Maria"; // string cadeia de palavras "aspas"

            Console.Write("Ola mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Ate mais.\n"); // \n para pular uma linha 

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("f2")); // para a string || para o texto no console f... ira diminuir a quntidade de zeros
            Console.WriteLine(x.ToString("f4"));
            Console.WriteLine(x.ToString("f2", CultureInfo.InvariantCulture));  // o CultureInfo.InvariantCulture sao do globalization permite as regras de outra lingua 
            //do ponto a virgula

            Console.WriteLine($"\nResultado = {x}"); // $ na string para declarar uma var dentro dela
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
           // int t;

            f = 5.0;
            b = (int)f; // para transformar de um jeito simples uma var e colocar a (var) antes da atribuicao do valor

            Console.WriteLine(f);
        }
    }
}
