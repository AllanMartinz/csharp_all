using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Fist
{
    class AttSec
    {
        public static void Executar()
        {
            /*
            Saida:
            AREA = 300.00
            PRECO =  60000.00

            area lar * com
            preco = area * preQ
            */

            //double lar = 10.0;
            //double com = 30.0;
            //double preQ= 200.00;

            //double area = lar * com;
            //double preco = area * preQ;

            //Console.WriteLine($"AREA = {area.ToString("f2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"PRECO = {preco.ToString("f2", CultureInfo.InvariantCulture)}");


            double lar, com, preQ, area, preco;

            lar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            com = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preQ = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // ao depurar la na barra la em cima ela vai marcar a linha com uma bolinha vermelha 
            // e o codigo vai iniciar apartir dessa bolinha f9
            area = lar * com;
            preco = area * preQ;
            // pra depurar uma unica linha por vez é a depuracao f10
            Console.WriteLine($"AREA = {area.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PRECO = {preco.ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}
