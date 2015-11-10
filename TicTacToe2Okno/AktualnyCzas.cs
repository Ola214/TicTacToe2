using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2Okno
{
    class AktualnyCzas
    {
        public void wypiszAktualnyCzas()
        {
            DateTime localDate = DateTime.Now;
            String cultureName = ("pl-PL");


            var culture = new CultureInfo(cultureName);
            Console.WriteLine(cultureName + " " + localDate.ToString(culture));
        }
    }
}
