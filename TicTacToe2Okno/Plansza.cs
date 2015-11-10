using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    public class Plansza
    {
        public int[,] d = new int[3, 3];

        public String wpisz(int x, int y)   //było char
        {
            char ch;
            switch (d[x, y])  //?dobrze
            {
                case 0:
                    ch = ' ';
                    return ch.ToString();  // ' ';
                case -1:
                    ch = 'O';
                    return ch.ToString();
                case 1:
                    ch = 'X';
                    return ch.ToString();
                default:
                    ch = ' ';
                    return ch.ToString();
            }
        }

        public void rysujPlansze()
        {
            Console.WriteLine(" " + wpisz(0, 0) + " | " + wpisz(0, 1) + " | " + wpisz(0, 2) + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + wpisz(1, 0) + " | " + wpisz(1, 1) + " | " + wpisz(1, 2) + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + wpisz(2, 0) + " | " + wpisz(2, 1) + " | " + wpisz(2, 2) + " ");
        }

        public int ruchWartosc(bool ruch)
        {
            if (ruch == true)
                return -1;
            else
                return 1;
        }

        public int[,] getD()
        {
            return d;
        }

        public void setD(int[,] d)
        {
            this.d = d;
        }
    }
}
