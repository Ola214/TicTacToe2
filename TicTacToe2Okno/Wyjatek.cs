using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    class Wyjatek
    {
        //zmienione z char na int
        int wyjatekRodzajGry(int rodzajGry)
        {

            while (rodzajGry != 1 && rodzajGry != 2)
            {
                Console.WriteLine("Nieprawidłowa wartość. Wpisz jeszcze raz: ");
                rodzajGry = Console.Read();
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                return rodzajGry;
            }
            return rodzajGry;
        }
   
    }
}
