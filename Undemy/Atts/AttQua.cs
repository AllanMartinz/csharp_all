using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp_all.Undemy.Atts {
    class AttQua {
        public static void Executar() {
            int idadePri, idadeSec;
            string nomePri, nomeSec;
            double media;

            string[] vetPri = Console.ReadLine().Split(' ');
            nomePri = vetPri[0];
            idadePri = int.Parse(vetPri[1]);

            string[] vetSec = Console.ReadLine().Split(' ');
            nomeSec = vetSec[0];
            idadeSec = int.Parse(vetSec[1]);

            media = (idadePri + idadeSec) / 2.0;

            Console.WriteLine($"A idade média de {nomePri} e {nomeSec} é de {media.ToString(CultureInfo.InvariantCulture)} anos");
        }
    }
}
