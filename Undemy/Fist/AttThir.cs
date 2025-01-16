using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Formats.Asn1;

namespace CSharp_all.Undemy.Fist
{
    class AttThir
    {
        public static void Executar()
        {
            double medidaBase, alturaRet, area, perimetro, diagonal;

            medidaBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alturaRet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = medidaBase * alturaRet;
            perimetro = 2 * (medidaBase + alturaRet);
            diagonal = Math.Sqrt(Math.Pow(medidaBase, 2.0) + Math.Pow(alturaRet, 2));

            Console.WriteLine($"AREA = {area.ToString("f4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMTRO = {perimetro.ToString("f4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("f4", CultureInfo.InvariantCulture)}");
        }
    }
}
