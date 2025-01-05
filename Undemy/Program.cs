using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharp_all.Undemy.Fist;

namespace CSharp_all.Undemy
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExecicios(new Dictionary<string, Action>()
            {
                {"Primeiro Exercicio", PrimeiroExercicio.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
