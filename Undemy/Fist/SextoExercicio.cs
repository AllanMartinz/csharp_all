namespace CSharp_all.Undemy.Fist {
    class SextoExercicio {
        public static void Executar() {
            //int x = 5;

            //Console.WriteLine("Bom dia");

            //if (x < 0) //no if so executa se for true
            //{
            //    Console.WriteLine("Boa tarde");
            //} else // caso se n for true ira rodar o else
            //{

            //}

            //Console.WriteLine("Boa Noite");

            int horas;

            Console.WriteLine("Quantas horas");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12) {
                Console.WriteLine("Bom dia");
            }
            else if (horas < 18) {
                Console.WriteLine("Boa tarde");
            }
            else { // o ultimo else sera so else 
                Console.WriteLine("Boa noite");
            }

        }
    }
}
