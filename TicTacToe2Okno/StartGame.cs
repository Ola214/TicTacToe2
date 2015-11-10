using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    class StartGame
    {
        public void StartGAME()
        {
            char odp;
            int rodzajGry; //był char rodzajGry;
            bool nastepnyGracz;
            bool komputer;
            int ruchGracza;
            int wynik;
            Profile pro = new Profile();
            //GraKomputer gra = new GraKomputer();
            //Rundy run = new Rundy();
            Console.WriteLine("Gra w kolko i krzyzyk - Nowa Gra");
            Console.WriteLine("Gra dla dwoch graczy - 1, gra z komputerem - 2");
            nastepnyGracz = false;


            rodzajGry = int.Parse(Console.ReadLine());
            Console.WriteLine(rodzajGry.GetType());


            if (rodzajGry == 1)
            {
                pro.podajProfil1();
                pro.podajProfil2();
            }
            if (rodzajGry == 2)
            {
                pro.podajProfil1();
            }

            Rundy run = new Rundy();
            do
            {
                Console.WriteLine("Jak grac: ");
                Console.WriteLine(" ");
                Console.WriteLine("1   |  2  |  3  ");
                Console.WriteLine("----+-----+-----");
                Console.WriteLine(" 4  |  5  |  6  ");
                Console.WriteLine("----+-----+-----");
                Console.WriteLine(" 7  |  8  |  9  ");
                GraKomputer gra = new GraKomputer();
                Console.WriteLine("Runda" + run.licznikRund + 1);
                Console.WriteLine("START!");

                do
                {
                    gra.p1.rysujPlansze();
                    if (rodzajGry == 1)
                    {
                        if (nastepnyGracz == true)
                        {
                            Console.WriteLine("Ruch gracza " + pro.gracz2 + ":");
                        }
                        else
                        {
                            Console.WriteLine("Ruch gracza " + pro.gracz1 + ":");
                        }
                        do
                        {
                            ruchGracza = int.Parse(Console.ReadLine());

                        } while (gra.ruchGracza(nastepnyGracz, ruchGracza));

                    }
                    else
                    {
                        if (nastepnyGracz == true)
                        {
                            Console.WriteLine("Ruch komputera");
                            gra.ruchKomputera(nastepnyGracz);
                        }
                        else
                        {
                            Console.WriteLine("Ruch gracza " + pro.gracz1 + ":");

                            do
                            {
                                ruchGracza = int.Parse(Console.ReadLine()); ;

                            } while (gra.ruchGracza(nastepnyGracz, ruchGracza));

                        }
                    }

                    nastepnyGracz = !nastepnyGracz;

                } while (gra.wygrana() == 0);


                gra.p1.rysujPlansze();

                wynik = gra.wygrana();

                if (wynik == 2)
                {
                    Console.WriteLine("REMIS");
                }
                else
                {
                    if (wynik == -1) Console.WriteLine("Wygral gracz KOLKO");

                    else Console.WriteLine("Wygral gracz KRZYZYK");
                }

                run.runda(wynik);
                Console.WriteLine("Kolejna runda? (t=TAK) ");
                odp = Console.ReadKey().KeyChar;

                Console.Clear();
                Console.WriteLine("KRZYZYK - " + pro.gracz1);
                if (rodzajGry == 1)
                    Console.WriteLine("KOLKO - " + pro.gracz2);

            } while (odp == 'T' || odp == 't');
            Console.Clear();




        }
    }
}
