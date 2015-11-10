using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    public class GraKomputer : Gra
    {


        public int[] ruchKomputera(bool ruch)
        {
            //srand(time(NULL));
            Random rnd = new Random();

            int x = rnd.Next(0, 3);  //rand() % 3; generator.nextInt(999) % 3;
            int y = rnd.Next(0, 3);  //rand() % 3;
            int[,] d = p1.getD();
            int[] tablica = new int[2];

            if (d[x, y] == 0)
            {
                d[x, y] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = x;
                tablica[1] = y;
            }
            else if (d[x, (y + 1) % 3] == 0)
            {
                d[x, (y + 1) % 3] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = x;
                tablica[1] = (y + 1) % 3;
            }
            else if (d[x, (y + 2) % 3] == 0)
            {
                d[x, (y + 2) % 3] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = x;
                tablica[1] = (y + 2) % 3;
            }
            else if (d[(x + 1) % 3, y] == 0)
            {
                d[(x + 1) % 3, y] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = (x + 1) % 3;
                tablica[1] = y;
            }
            else if (d[(x + 1) % 3, (y + 1) % 3] == 0)
            {
                d[(x + 1) % 3, (y + 1) % 3] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = (x + 1) % 3;
                tablica[1] = (y + 1) % 3;
            }
            else if (d[(x + 1) % 3, (y + 2) % 3] == 0)
            {
                d[(x + 1) % 3, (y + 2) % 3] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = (x + 1) % 3;
                tablica[1] = (y + 2) % 3;
            }
            else if (d[(x + 2) % 3, y] == 0)
            {
                d[(x + 2) % 3, y] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = (x + 2) % 3;
                tablica[1] = y;
            }
            else if (d[(x + 2) % 3, (y + 1) % 3] == 0)
            {
                d[(x + 2) % 3, (y + 1) % 3] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = (x + 2) % 3;
                tablica[1] = (y + 1) % 3;
            }
            else if (d[(x + 2) % 3, (x + 2) % 3] == 0)
            {
                d[(x + 2) % 3, (x + 2) % 3] = p1.ruchWartosc(ruch);
                p1.setD(d);
                tablica[0] = (x + 2) % 3;
                tablica[1] = (x + 2) % 3;
            }
            
            return tablica;
        }

    }
}
