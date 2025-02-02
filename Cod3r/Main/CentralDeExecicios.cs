﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_all.Cod3r.Main
{
    class CentralDeExecicios
    {
        Dictionary<string, Action> Exercicios;

        public CentralDeExecicios(Dictionary<string, Action> exercicios)
        {
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar()
        {
            int i = 1;

            foreach(var exercicio in Exercicios)
            {
                Console.WriteLine("{0}) {1}", i, exercicio.Key);
                i++;
            }

            Console.WriteLine("Digite o Numero (ou vazio para o ultimo)?");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Exercicios.Count;
            num = numValido ? num - 1 : Exercicios.Count - 1;

            string nomeDoExercicio = Exercicios.ElementAt(num).Key;

            Console.Write("\nExecutando exercicio ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nomeDoExercicio);
            Console.ResetColor();

            Console.WriteLine(String.Concat(Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

            Action executar = Exercicios.ElementAt(num).Value;
            try
            {
                executar();
            } catch (Exception e)
            {
                Console.BackgroundColor= ConsoleColor.Red;
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
