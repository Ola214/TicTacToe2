using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2Okno
{
    class Kontrolka : PictureBox
    {
        private Bitmap zwykla;
        private Bitmap wcisnieta;
        private Bitmap fokus;
        private Boolean flagDown = false;
        private int pozycjaX;
        private int pozycjaY;

        public Kontrolka(String sciezkaDoZwykly, String sciezkaDoWcisniety, String sciezkaDoFokus, int pozycjaX, int pozycjaY, String etykieta)
        {
            this.pozycjaX = pozycjaX;
            this.pozycjaY = pozycjaY;
            zwykla = new Bitmap(sciezkaDoZwykly);
            wcisnieta = new Bitmap(sciezkaDoWcisniety);
            fokus = new Bitmap(sciezkaDoFokus);
            Image = zwykla;
            BackColor = Color.Transparent;
            Tag = etykieta;
            Location = new Point(pozycjaX, pozycjaY);
            Height = zwykla.Height;
            Width = zwykla.Width;

            MouseDown += new MouseEventHandler(mouseClickDown);
            MouseUp += new MouseEventHandler(mouseClickUp);
            MouseMove += new MouseEventHandler(mouseMove);
            MouseLeave += mouseLeave;
        }

        private void mouseClickDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && flagDown == false)
            {
                flagDown = true;
                Image = wcisnieta;
            }
            else
            {
                flagDown = false;
            }
        }

        private void mouseClickUp(object sender, MouseEventArgs e)
        {
            flagDown = false;
            Image = zwykla;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if(flagDown == false){
                Image = fokus;
            }     
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Image = zwykla;
        }

        public int getPozycjaX()
        {
            return pozycjaX;
        }

        public int getPozycjaY()
        {
            return pozycjaY;
        }
    }
}
