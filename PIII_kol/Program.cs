using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace PIII_kol
{
    class Komentarz
    {
        public string Autor;
        public string KomentowanyPost;
        public string Tresc;
        public string Tagi;
        public string CzasStworzenia;

        public Komentarz(string autor, string komentowany, string tresc, string tagi, string czas)
        {
            Autor = autor;
            KomentowanyPost = komentowany;
            Tresc = tresc;
            Tagi = tagi;
            CzasStworzenia = czas;
        }
    }

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
            CD = 5
        };
        static void Main(string[] args)
        {
            int minuty = 0;
            int sekundy = 0;
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
            Console.WriteLine($"lacznie trenowales {suma_minut} minut i {suma_Sekund} sekund podczas {trening} treningow");

            Console.WriteLine("Dostępne Opcje modułu komfortu: ");
            for (int val = 0; val <= 5; val++)
                Console.WriteLine("{0,4} - {1:G}", val, (Kontrola)val);
            
            //nie wiem w jaki sposób dać użytkownikowi możliwość wyboru 
            
               

        }
    }
}
