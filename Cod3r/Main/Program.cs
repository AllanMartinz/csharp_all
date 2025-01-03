using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharp_all.Cod3r.Main.Api;
using CSharp_all.Cod3r.Main.Avancados;
using CSharp_all.Cod3r.Main.ClassesMetodos;
using CSharp_all.Cod3r.Main.Colecoes;
using CSharp_all.Cod3r.Main.EstruturaControle;
using CSharp_all.Cod3r.Main.Excecoes;
using CSharp_all.Cod3r.Main.Fundamentos;
using CSharp_all.Cod3r.Main.MetodosFuncoes;
using CSharp_all.Cod3r.Main.OO;
using CSharp_all.Cod3r.Main.Test;

namespace CSharp_all.Cod3r.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExecicios(new Dictionary<string, Action>()
            {
                {"",}
            });

            central.SelecionarEExecutar();
        }
    }
}
