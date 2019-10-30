using System.Windows.Forms;

namespace C3_1
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        private static int iloscKol;
        public Car()
        {
            pojemnoscSilnika = 1.4;
            marka = "Volkswagen";
            iloscKol = 4;
        }

        public Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
            iloscKol = 4;
        }

        ~Car()
        {
            MessageBox.Show("Zwalniam pamiec");
        }
    }
}
