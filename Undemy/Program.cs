using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_all.Undemy.Atts;
using CSharp_all.Undemy.Exercicios;
using CSharp_all.Undemy.Uri;

namespace CSharp_all.Undemy {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExecicios(new Dictionary<string, Action>()
            {
                //exercicios
                {"Primeiro Exercicio", PrimeiroExercicio.Executar},
                {"Segundo Exercicio", SegundoExercicio.Executar},
                {"Terceiro Exercicio", TerceiroExercicio.Executar},
                {"Quarto Exercicio", QuartoExercicio.Executar},
                {"Quinto Exercicio", QuintoExercicio.Executar},
                {"Sexto Exercicio", SextoExercicio.Executar},
                {"Setimo Exercicio", SetimoExcercicio.Executar},
                {"Oitavo Exercicio", OitavoExercicio.Executar},
                {"Nono Exercicio", NonoExercicio.Executar},

                //atividades
                {"Atividade 01", AttFirst.Executar},
                {"Atividade 02", AttSec.Executar},
                {"Atividade 03", AttThir.Executar},
                {"Atividade 04", AttQua.Executar},
                {"Atividade 05", AttQui.Executar},

                //Uris
                {"Uri 01", Uri01.Executar},
                {"Uri 19", Uri19.Executar},
                {"Uri 36", Uri36.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}
