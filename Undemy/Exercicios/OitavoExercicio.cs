using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Undemy.Exercicios {
    class OitavoExercicio {
        //uma telefonia cobra rs50.00 por 100 minutos
        //cada minuto que exeder 100 minutos add rs2.00
        //ler a qunatidade de minutos consumidos
        //mostrar o valor a ser pago
        public static void Executar() {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if(minutos > 100) {
                conta += (minutos - 100) * 2.0;
              //conta = conta + (minutos - 100) * 2.0;
            }

            Console.WriteLine($"Valor a pagar: R${conta.ToString("f2",CultureInfo.InvariantCulture)}");

            /*
             Acumalativos:
                a += b; --> a = a + b;    
                a -= b; --> a = a - b;
                a *= b; --> a = a * b;
                a /= b; --> a = a / b;
                a %= b; --> a = a % b;
            */
        }

    }
}
