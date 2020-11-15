using System;

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
            while ((Console.ReadLine() == "tak") || (Console.ReadLine() == "nie"));
            Console.WriteLine($"lacznie trenowales {suma_minut}minut i {suma_Sekund} sekund podczas {trening} treningow");

            Komentarz a = new Komentarz("autor","test");
        }
    }
}
