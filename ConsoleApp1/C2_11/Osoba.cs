using System;

namespace C2_11
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public Plec plec;

        public Osoba(string imie, string nazwisko, int rokUrodzenia, int waga, int wzrost, bool okulary, Plec plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.waga = waga;
            this.wzrost = wzrost;
            this.okulary = okulary;
            this.plec = plec;
        }

       
        public int obliczWiek()
        {
            return DateTime.Now.Year - this.rokUrodzenia;
        }

       public string tytul()
        {
            if  (this.plec == 0)
                {
                return "Pani";
                }
            else
                {
                return "Pan";
                }
        }

        public double bmi()
        {
            double x = Convert.ToDouble(this.wzrost);
            return this.waga/Math.Pow(x/100, 2);
        }
    }
    public enum Plec
    {
        K, M
    }

}
