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
                //exercicios
                {"Primeiro Exercicio", PrimeiroExercicio.Executar},
                {"Segundo Exercicio", SegundoExercicio.Executar},
                {"Terceiro Exercicio", TerceiroExercicio.Executar},
                {"Quarto Exercicio", QuartoExercicio.Executar},
                {"Quinto Exercicio", QuintoExercicio.Executar},

                //atividades
                {"Atividade 01", AttFirst.Executar},
                {"Atividade 02", AttSec.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
