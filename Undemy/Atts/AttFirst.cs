using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Atts {
    class AttFirst {
        public static void Executar() {

            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int room = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double cost = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split();
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"\n{fullName}");
            Console.WriteLine(room);
            Console.WriteLine(cost.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("f2", CultureInfo.InvariantCulture));




        }
    }
}
