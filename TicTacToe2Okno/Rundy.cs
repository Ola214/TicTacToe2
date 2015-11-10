using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    class Rundy
    {
        protected int licznikKolko = 0;
        protected int licznikKrzyzyk = 0;


        public int licznikRund = 0; //private


        public void runda(int wynik)
        {
            if (wynik == 2) licznikRund++;
            if (wynik == -1)
            {
                licznikKolko++;
                licznikRund++;
            }
            if (wynik == 1)
            {
                licznikKrzyzyk++;
                licznikRund++;
            }
            Console.WriteLine("Runda " + licznikRund + " zakonczona. Wyniki: ");
            Console.WriteLine("Gracz KOLKO: " + licznikKolko + " punktow. ");
            Console.WriteLine("Gracz KRZYZYK: " + licznikKrzyzyk + " punktow. ");



            AktualnyCzas czas = new AktualnyCzas();
            czas.wypiszAktualnyCzas();
        }

        public int getLicznikKolko()
        {
            return licznikKolko;
        }

        public void setLicznikKolko(int licznikKolko)
        {
            this.licznikKolko = licznikKolko;
        }

        public int getLicznikKrzyzyk()
        {
            return licznikKrzyzyk;
        }

        public void setLicznikKrzyzyk(int licznikKrzyzyk)
        {
            this.licznikKrzyzyk = licznikKrzyzyk;
        }

        public int getLicznikRund()
        {
            return licznikRund;
        }

        public void setLicznikRund(int licznikRund)
        {
            this.licznikRund = licznikRund;
        }
    
    }
}
