using System;
using System.Collections.Generic;
using System.Text;

namespace PIII_kol
{
    class Komentarz
    {
        
        public string Autor;
        public string KomentowanyPost;
        public string Tresc;
        public string[] Tagi;
        public DateTime CzasStworzenia;

        public Komentarz(string autor, string komentowany, string tresc, string[] tagi, DateTime czasStworzenia)
        {
            if (string.IsNullOrWhiteSpace(komentowany) || string.IsNullOrWhiteSpace(autor))
                throw new ArgumentException("Autor i Komentowany post nie mogą być puste");
            else
            {
                Autor = autor;
                KomentowanyPost = komentowany;
            }
        
            Tresc = tresc;

            //if (Array.GetLength(tagi[]) <= 0)
            //    throw new ArgumentException("Tagi nie mogą być puste");
            //else
            //{ 
            Tagi = tagi;
            //}
            DateTime data = new DateTime(2020, 1, 1);
            if (czasStworzenia < data) CzasStworzenia = czasStworzenia;
            else throw new ArgumentException("Data utworzenia nie może być starsza niż 01.01.2020r");
        }
    }
        
}

