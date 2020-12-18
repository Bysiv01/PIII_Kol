using System;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Collections.Generic;

namespace PIII_kol
{


    class Program
    {
        public static void Wypisz()
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("{0,4} - {1:G}", i, (Kontrola)i);

                }
            }
        enum Kontrola
        {
            Chłodzenie,
            Nagrzewanie,
            Klimatyzacja,
            Nawigacja,
            Radio,
            CD,
            Wyjscie
        };
        public static Komentarz[] Komentarze = new[]
        {
            new Komentarz("uzytkownik1","post1","wypowiedz",new[] {"tag"} ,new DateTime(2019, 12 ,12))
        };

        static void Main(string[] args)
        {
            int minuty;
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

            
                int NrOpcji;
                string val;
            do
            {
                Console.WriteLine("Dostępne funkcje:");
                Wypisz();
                val = Console.ReadLine();
                NrOpcji = Convert.ToInt32(val);

                Kontrola kontrola;

                if (NrOpcji == 0)
                {
                    kontrola = Kontrola.Chłodzenie;
                }
                else if (NrOpcji == 1)
                {
                    kontrola = Kontrola.Nagrzewanie;
                }
                else if (NrOpcji == 2)
                {
                    kontrola = Kontrola.Klimatyzacja;
                }
                else if (NrOpcji == 3)
                {
                    kontrola = Kontrola.Nawigacja;
                }
                else if (NrOpcji == 4)
                {
                    kontrola = Kontrola.Radio;
                }
                else
                {
                    kontrola = Kontrola.CD;
                }

                
                switch (kontrola)
                {
                    case Kontrola.Chłodzenie:
                        Console.WriteLine("Chłodzenie aktywowane");
                        break;
                    case Kontrola.Nagrzewanie:
                        Console.WriteLine("Nagrzewanie aktywowane");
                        break;
                    case Kontrola.Klimatyzacja:
                        Console.WriteLine("Klimatyzacja aktywowana");
                        break;
                    case Kontrola.Nawigacja:
                        Console.WriteLine("Nawigacja aktywowana");
                        break;
                    case Kontrola.Radio:
                        Console.WriteLine("Radio aktywowane");
                        break;
                    case Kontrola.CD:
                        Console.WriteLine("CD aktywowane");
                        break;
                }

            } while (NrOpcji != 6);

            Komentarz komentarz = new Komentarz("uzytkownik1", "post1", "wypowiedz", new[] { "tag","tag2" }, new DateTime(2019, 12 ,12));
    
            Console.WriteLine(komentarz.Autor);
            Console.WriteLine(komentarz.KomentowanyPost);
            Console.WriteLine(komentarz.Tresc);
            foreach (var tags in komentarz.Tagi) 
            {
                Console.WriteLine(tags);
            }

            Console.WriteLine(komentarz.CzasStworzenia);
        }
    }
}
