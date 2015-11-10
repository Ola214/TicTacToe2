using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    class Profile
    {
        public String gracz1;// string gracz1;
        public String gracz2; //string



        public String podajProfil1() //string był
        {

            Console.WriteLine("Podaj nazwe gracza nr 1 - KRZYZYK:");
            gracz1 = Console.ReadLine();
            Console.WriteLine("");

            return gracz1;
        }

        public String podajProfil2()//string
        {
            Console.WriteLine("Podaj nazwe gracza nr 2 - KOLKO:");
            gracz2 = Console.ReadLine();
            Console.WriteLine("");

            return gracz2;
        }


        //zmienione ze String na int:

        public String getGracz1()
        {
            return gracz1;
        }

        public void setGracz1(String gracz1)
        {
            this.gracz1 = gracz1;
        }

        public String getGracz2()
        {
            return gracz2;
        }

        public void setGracz2(String gracz2)
        {
            this.gracz2 = gracz2;
        }

    }
}
