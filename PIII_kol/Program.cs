﻿using System;
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
            int suma_minut = 0;
            int suma_Sekund = 0;
            int trening = 0;
            do
            {
                trening++;
                
                Console.WriteLine($"trening{trening}");
                Console.WriteLine("ile minut cwiczyles?");
                minuty = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("ile sekund cwiczyles?");
                sekundy = System.Int32.Parse(Console.ReadLine());
                
                suma_minut += minuty;
                suma_Sekund += sekundy;

                Console.WriteLine("Kolejny trening? tak/nie");
            }
            while ((Console.ReadLine() == "tak"));
            Console.WriteLine($"lacznie trenowales {suma_minut} minut(y) i {suma_Sekund} sekund(y) podczas {trening} treningow");

            int NrOpcji;
            string val;

            Kontrola kontrola;
            
            do
            {

                Console.WriteLine("Dostępne funkcje:");
                Wypisz();
                val = Console.ReadLine();
                NrOpcji = Convert.ToInt32(val);


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
                else if (NrOpcji == 5)
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
