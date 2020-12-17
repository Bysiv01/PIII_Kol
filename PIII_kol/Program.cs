using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace PIII_kol
{


    class Program
    {
        [Flags]
        enum Kontrola : short
        {
            Chłodzenie = 0,
            Nagrzewanie = 1,
            Klimatyzacja = 2,
            Nawigacja = 3,
            Radio = 4,
            CD = 5,
            wyjscie = 6
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

            static void wypisz()
            {
                Console.WriteLine("Dostępne Opcje modułu komfortu: ");
                for (int value = 0; value <= 5; value++)
                    Console.WriteLine("{0,4} - {1:G}", value, (Kontrola)value);
            }

            do
            { 
            string value;
            int NrOpcji;
            wypisz();
            value = Console.ReadLine();
            NrOpcji = Convert.ToInt32(value);
                switch (NrOpcji)
                {
                    case 0:
                        Console.WriteLine($"{Kontrola.Chłodzenie} 1");
                        break;
                    case 1:
                        Console.WriteLine($"{Kontrola.Nagrzewanie} 1");
                        break;
                    case 2:
                        Console.WriteLine($"{Kontrola.Klimatyzacja} 1");
                        break;
                    case 3:
                        Console.WriteLine($"{Kontrola.Nawigacja} 1");
                        break;
                    case 4:
                        Console.WriteLine($"{Kontrola.Radio} 1");
                        break;
                    case 5:
                        Console.WriteLine($"{Kontrola.CD} 1");
                        break;
                }
                Console.WriteLine("x aby kontynuowac");
            }
            while ((Console.ReadLine() == "x"));

            Komentarz komentarz = new Komentarz("uzytkownik1", "post1", "wypowiedz", new[] { "tag" }, new DateTime(2019, 12 ,12));
    
            Console.WriteLine(komentarz.Autor);
            Console.WriteLine(komentarz.KomentowanyPost);
            Console.WriteLine(komentarz.Tresc);
            Console.WriteLine(komentarz.Tagi);
            Console.WriteLine(komentarz.CzasStworzenia);
        }
    }
}
