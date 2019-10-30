using System.Collections.Generic;

namespace ConsoleApp2
{
    class Produkt
    {
        public string nazwa;
        public double cena;

        public Produkt(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
    }

    class Koszyk
    {
        List<Produkt> produkty;

        public Koszyk()
        {
            this.produkty = new List<Produkt>();
        }
        public void DodajProdukt(Produkt p)
        {
            this.produkty.Add(p);
        }
        public int IleProduktow()
        {
            return this.produkty.Count;
        }
        public double WartoscKoszyka()
        {
        double suma = 0;
        foreach(Produkt p in produkty)
            suma += p.cena;
        return suma;
        }
    }
}
