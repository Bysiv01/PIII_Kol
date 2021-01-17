using System;
using System.Collections.Generic;
using System.Text;

namespace PIII_kol
{
    class Komentarz
    {
        public string Autor
        {
            get => Autor;
            set
            {
                if (string.IsNullOrWhiteSpace(Autor))
                    throw new ArgumentException("Autor nie mogą być puste");
                else
                {
                    Autor = Autor;
                }
            }
        }
        
        public string Komentowany
        {
            get => Komentowany;
            set
            {
                if (string.IsNullOrWhiteSpace(Komentowany))
                    throw new ArgumentException("Komentowany post nie mogą być puste");
                else
                {
                    Komentowany = Komentowany;
                }
            }
        }
        
        public string Tresc 
        {
            get;
            set;
        }

        public string[] Tagi
        {
            get => Tagi;
            set
            {
                if (Tagi.Length <= 0)
                    throw new ArgumentException("Tagi nie mogą być puste");
                else
                {
                    Tagi = Tagi;
                }
            }
        }

        public DateTime CzasStworzenia
        {
            get => CzasStworzenia;
            set
            {
                DateTime data = new DateTime(2020, 1, 1);
                if (CzasStworzenia < data)
                {
                    CzasStworzenia = CzasStworzenia;
                }
                else
                {
                    throw new ArgumentException("Data utworzenia nie może być starsza niż 01.01.2020r");
                }
            }
        }
        public Komentarz()
        {
            this.Autor = Autor;
            this.Komentowany = Komentowany;
            this.Tresc = Tresc;
            this.Tagi = Tagi;
            this.CzasStworzenia = CzasStworzenia;
        }
    }
        
}

