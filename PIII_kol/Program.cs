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
        [Flags]
        enum Kontrola
        {
            nieaktywne = 0,
            Chłodzenie = 1,
            Nagrzewanie = 2,
            Klimatyzacja = 4,
            Nawigacja = 8,
            Radio = 16,
            CD = 32,
            Wyjscie = 64
        };
        public static void Wypisz()
            {
                for (int i = 0; i < 64; i++)
                {
                    Console.WriteLine("{0,4} - {1:G}", i, (Kontrola)i);

                }
            }
        public static Komentarz[] Komentarze = new[]
        {
            new Komentarz("uzytkownik1","post1","wypowiedz",new[] {"tag"} ,new DateTime(2019, 12 ,12))
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Dostępne funkcje:");
            Wypisz();
            int NrOpcji;
            string val;
            do
            {
                val = Console.ReadLine();
                NrOpcji = Convert.ToInt32(val);

                Kontrola kontrola;

                if (NrOpcji == 0)
                {
                    kontrola = Kontrola.nieaktywne;
                }
                else if (NrOpcji == 1)
                {
                    kontrola = Kontrola.Chłodzenie;
                }
                else if (NrOpcji == 2)
                {
                    kontrola = Kontrola.Nagrzewanie;
                }
                else if (NrOpcji == 3)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie;
                }
                else if (NrOpcji == 4)
                {
                    kontrola = Kontrola.Klimatyzacja;
                }
                else if (NrOpcji == 5)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja;
                }
                else if (NrOpcji == 6)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja;
                }
                else if (NrOpcji == 7)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja;
                }
                else if (NrOpcji == 8)
                {
                    kontrola = Kontrola.Nawigacja;
                }
                else if (NrOpcji == 9)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nawigacja;
                }
                else if (NrOpcji == 10)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Nawigacja;
                }
                else if (NrOpcji == 11)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Nawigacja;
                }
                else if (NrOpcji == 12)
                {
                    kontrola = Kontrola.Klimatyzacja | Kontrola.Nawigacja;
                }
                else if (NrOpcji == 13)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Nawigacja;
                }
                else if (NrOpcji == 14)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja;
                }
                else if (NrOpcji == 15)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja |
                Kontrola.Nawigacja;
                }
                else if (NrOpcji == 16)
                {
                    kontrola = Kontrola.Radio;
                }
                else if (NrOpcji == 17)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Radio;
                }
                else if (NrOpcji ==18)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Radio;
                }
                else if (NrOpcji == 19)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Radio;
                }
                else if (NrOpcji == 20)
                {
                    kontrola = Kontrola.Klimatyzacja | Kontrola.Radio;
                }
                else if (NrOpcji == 21)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Radio;
                }
                else if (NrOpcji == 22)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Radio;
                }
                else if (NrOpcji == 23)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja |
                Kontrola.Radio;
                }
                else if (NrOpcji == 24)
                {
                    kontrola = Kontrola.Nawigacja | Kontrola.Radio;
                }
                else if (NrOpcji == 25)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nawigacja | Kontrola.Radio;;
                }
                else if (NrOpcji == 26)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Nawigacja | Kontrola.Radio;
                }
                else if (NrOpcji == 27)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Nawigacja |
                Kontrola.Radio;
                }
                else if (NrOpcji == 28)
                {
                    kontrola =  Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.Radio;
                }
                else if (NrOpcji == 29)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja| Kontrola.Nawigacja |
                Kontrola.Radio;
                }
                else if (NrOpcji == 30)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                Kontrola.Radio;
                }
                else if (NrOpcji == 31)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja |
                Kontrola.Nawigacja | Kontrola.Radio;
                }
                else if (NrOpcji == 32)
                {
                    kontrola = Kontrola.CD;
                }
                else if (NrOpcji == 33)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.CD;
                }
                else if (NrOpcji == 34)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.CD;
                }
                else if (NrOpcji == 35)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.CD;
                }
                else if (NrOpcji == 36)
                {
                    kontrola = Kontrola.Klimatyzacja | Kontrola.CD;
                }
                else if (NrOpcji == 37)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.CD;
                }
                else if (NrOpcji == 38)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.CD;
                }
                else if (NrOpcji == 39)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja |
                Kontrola.CD;
                }
                else if (NrOpcji == 40)
                {
                    kontrola = Kontrola.Nawigacja | Kontrola.CD;
                }
                else if (NrOpcji == 41)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nawigacja | Kontrola.CD;
                }
                else if (NrOpcji == 42)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Nawigacja | Kontrola.CD;
                }
                else if (NrOpcji == 43)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Nawigacja | 
                Kontrola.CD;
                }
                else if (NrOpcji == 44)
                {
                    kontrola = Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.CD;
                }
                else if (NrOpcji == 45)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.CD;
                }
                else if (NrOpcji == 46)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                Kontrola.CD;
                }
                else if (NrOpcji == 47)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja |
                Kontrola.Nawigacja | Kontrola.CD;
                }
                else if (NrOpcji == 48)
                {
                    kontrola = Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 49)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 50)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 51)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Radio |
                Kontrola.CD;
                }
                else if (NrOpcji == 52)
                {
                    kontrola = Kontrola.Klimatyzacja | Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 53)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Radio |
                Kontrola.CD;
                }
                else if (NrOpcji == 54)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Radio |
                Kontrola.CD;
                }
                else if (NrOpcji == 55)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja |
                Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 56)
                {
                    kontrola = Kontrola.Nawigacja | Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 57)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nawigacja | Kontrola.Radio |
                Kontrola.CD;
                }
                else if (NrOpcji == 58)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Nawigacja| Kontrola.Radio |
                Kontrola.CD;
                }
                else if (NrOpcji == 59)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Nawigacja |
                Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 60)
                {
                    kontrola = Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.Radio |
                Kontrola.CD;
                }
                else if (NrOpcji == 61)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 62)
                {
                    kontrola = Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                Kontrola.Radio | Kontrola.CD;
                }
                else if (NrOpcji == 63)
                {
                    kontrola = Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | 
                Kontrola.Nawigacja | Kontrola.Radio | Kontrola.CD;
                }
                switch (kontrola)
                {
                    case Kontrola.nieaktywne:
                        Console.WriteLine("nieaktywne");
                        break;
                    case Kontrola.Chłodzenie:
                        Console.WriteLine("Chłodzenie aktywne");
                        break;
                    case Kontrola.Nagrzewanie:
                        Console.WriteLine("Nagrzewanie aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie:
                        Console.WriteLine("Chłodzenie i Nagrzewanie aktywne");
                        break;
                    case Kontrola.Klimatyzacja:
                        Console.WriteLine("Klimatyzacja aktywna");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Klimatyzacja:
                        Console.WriteLine("Chłodzenie i Klimatyzacja aktywne");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Klimatyzacja:
                        Console.WriteLine("Nagrzewanie i Klimatyzacja aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja:
                        Console.WriteLine("Chłodzenie, Nagrzewanie i Klimatyzacja aktywne");
                        break;
                    case Kontrola.Nawigacja:
                        Console.WriteLine("Nawigacja aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nawigacja:
                        Console.WriteLine("Nawigacja i chłodzenie aktywne");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Nawigacja:
                        Console.WriteLine("Nagrzewanie i Nawigacja aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Nawigacja:
                        Console.WriteLine("Chłodzenie, Nagrzewanie i Nawigacja aktywne");
                        break;
                    case Kontrola.Klimatyzacja | Kontrola.Nawigacja:
                        Console.WriteLine("Klimatyzacja i Nawigacja aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Nawigacja:
                        Console.WriteLine("Chłodzenie, Klimatyzacja i Nawigacja aktywne");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja:
                        Console.WriteLine("Nagrzewanie, Klimatyzacja i Nawigacja aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja:
                        Console.WriteLine("Chłodzenie, Nagrzewanie, Klimatyzacja i Nawigacja aktywne");
                        break;
                    case Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Klimatyzacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.Radio:
                        Console.WriteLine("Radio aktywowanie");
                        break;
                    case Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Klimatyzacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Nawigacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nawigacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Nawigacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Nawigacja 
                    | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Klimatyzacja | Kontrola.Nawigacja | Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                    Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                    Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Chłodzenie | Kontrola.Nagrzewanie | Kontrola.Klimatyzacja | Kontrola.Nawigacja |
                    Kontrola.CD:
                        Console.WriteLine("CD Aktywne");
                        break;
                    case Kontrola.Radio | Kontrola.CD:
                        Console.WriteLine("Radio i CD Aktywne");
                        break;

                }
                

            } while (NrOpcji != 0);





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
