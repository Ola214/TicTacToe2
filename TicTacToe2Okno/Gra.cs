using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    class Gra
    {

        public Plansza p1 = new Plansza();

        public Gra()
        {
            int[,] d;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    d = p1.getD();
                    d[i, j] = 0;
                    p1.setD(d);
                }
            }
        }

        private int kolumny(int x)
        {
            int[,] d = p1.getD();
            return p1.d[0, x] + p1.d[1, x] + p1.d[2, x];
        }


        private int wiersze(int x)
        {
            int[,] d = p1.getD();
            return p1.d[x, 0] + p1.d[x, 1] + p1.d[x, 2];
        }


        public int wygrana()
        {
            for (int i = 0; i < 3; i++)
            {
                if (kolumny(i) == -3 || wiersze(i) == -3)
                    return -1;
                if (kolumny(i) == 3 || wiersze(i) == 3)
                    return 1;
            }

            int[,] d = p1.getD();
            if (p1.d[0, 0] == -1 && p1.d[1, 1] == -1 && p1.d[2, 2] == -1 || p1.d[0, 2] == -1 && p1.d[1, 1] == -1 && p1.d[2, 0] == -1)
                return -1;
            if (p1.d[0, 0] == 1 && p1.d[1, 1] == 1 && p1.d[2, 2] == 1 || p1.d[0, 2] == 1 && p1.d[1, 1] == 1 && p1.d[2, 0] == 1)
                return 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (p1.d[i, j] == 0)
                        return 0;
                }
            }

            return 2;
        }

        public bool ruchGracza(bool ruch, int x)
        {
            x = x - 1;

            int[,] d = p1.getD();

            if (p1.d[x / 3, x % 3] != 0)
            {
                Console.WriteLine("Nieprawidlowy ruch. Sprobuj jeszcze raz: ");
                return true;
            }

            p1.d[x / 3, x % 3] = p1.ruchWartosc(ruch);
            return false;

        }

        public Plansza getP1()
        {
            return p1;
        }

        public void setP1(Plansza p1)
        {
            this.p1 = p1;
        }

    }
}
