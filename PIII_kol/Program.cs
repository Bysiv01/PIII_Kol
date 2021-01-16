using System;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Collections.Generic;

namespace PIII_kol
{

        [Flags]
        public enum Kontrola
        {
            Nieaktywne = 0,
            Chłodzenie = 1,
            Nagrzewanie = 2,
            Klimatyzacja = 4,
            Nawigacja = 8,
            Radio = 16,
            CD = 32
        };

    class Program
    {
        public static Komentarz[] Komentarze = new[]
        {
            new Komentarz("uzytkownik1","post1","wypowiedz",new[] {"tag"} ,new DateTime(2019, 12 ,12))
        };

        public static void Main()
        {
          /*int minuty;
            int sekundy;
            int godziny;

            int suma_minut = 0;
            int suma_sekund = 0;
            int suma_godzin = 0;
            
            int trening = 0;

            do
            {
                trening++;
                Console.WriteLine($"trening: {trening}");

                Console.WriteLine("ile godzin cwiczyles?");
                godziny = System.Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("ile minut cwiczyles?");
                minuty = System.Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("ile sekund cwiczyles?");
                sekundy = System.Int32.Parse(Console.ReadLine());
                
                suma_minut += minuty;
                suma_sekund += sekundy;
                suma_godzin += godziny;

                if (sekundy >= 60)
                {
                    minuty++;

                    sekundy -= 60;
                }
                if (minuty >= 60)
                {
                    godziny++;

                    minuty -= 60;
                }
                if (suma_sekund >= 60)
                {
                    suma_minut++;

                    suma_sekund -= 60;
                }
                if (suma_minut >= 60)
                {
                    suma_godzin++;

                    suma_minut -= 60;
                }
                
                Console.WriteLine($"dotychczas trenowales {godziny} godzin {minuty} minut {sekundy} sekund");
                Console.WriteLine("Kolejny trening? tak/nie");
            } while (Console.ReadLine() == "tak");
            Console.WriteLine($"lacznie trenowales {suma_godzin} godzin {suma_minut} minut i { suma_sekund} sekund podczas {trening} treningów"); ;
            */
            
            var stan = Kontrola.Nieaktywne;
            int opcja = 0;
            do
            {
                var x = Console.ReadKey().Key;
                var flag = (Kontrola)(Math.Pow(2, opcja));
                if (stan.HasFlag(flag))
                {
                    stan &= ~flag;
                }
                else
                {
                    stan ^= flag;
                }
                Console.WriteLine(stan);
            } while (opcja >= 0 && opcja<= 5);


            

            /*Komentarz komentarz = new Komentarz("uzytkownik1", "post1", "wypowiedz", new[] { "tag","tag2" }, new DateTime(2019, 12 ,12));
    
            Console.WriteLine(komentarz.Autor);
            Console.WriteLine(komentarz.KomentowanyPost);
            Console.WriteLine(komentarz.Tresc);
            foreach (var tags in komentarz.Tagi) 
            {
                Console.WriteLine(tags);
            }

            Console.WriteLine(komentarz.CzasStworzenia);*/
        }
    }
}
