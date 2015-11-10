using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2Okno
{
    public partial class GraKomputerForm : Form
    {
        Rundy runda;
        GraKomputer gra;
        Boolean nastepnyGracz;
        int wynik;
        Profile profile;
        private Kontrolka[,] pola;
        private Kontrolka kontrolkaMenu;
        private Kontrolka kontrolkaExit;
        private Bitmap pngLogo;
        private PictureBox logo;
        int[] poleKomp;


        public GraKomputerForm(Rundy runda, Profile profile, GraKomputer gra, Boolean nastepnyGracz)
        {
            poleKomp = new int[2];
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            this.DoubleBuffered = true;

            InitializeComponent();

            this.runda = runda;
            this.gra = gra;
            this.nastepnyGracz = nastepnyGracz;
            this.profile = profile;
            pola = new Kontrolka[3, 3];

            logo = new PictureBox();
            pngLogo = new Bitmap(@"Drawable\logoMsg.png");
            logo.BackColor = Color.Transparent;
            logo.Image = pngLogo;
            logo.Width = pngLogo.Width;
            logo.Height = pngLogo.Height;
            logo.Location = new Point(250, 20);

            pola[0, 0] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 540, 150, "Pole00Tag");
            pola[0, 1] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 604, 150, "Pole01Tag");
            pola[0, 1] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 604, 150, "Pole01Tag");
            pola[0, 1] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 604, 150, "Pole01Tag");
            pola[0, 2] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 668, 150, "Pole02Tag");
            pola[1, 0] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 540, 214, "Pole10Tag");
            pola[1, 1] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 604, 214, "Pole11Tag");
            pola[1, 2] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 668, 214, "Pole12Tag");
            pola[2, 0] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 540, 278, "Pole20Tag");
            pola[2, 1] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 604, 278, "Pole21Tag");
            pola[2, 2] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 668, 278, "Pole22Tag");
            pola[2, 2] = new Kontrolka(@"Buttons\GameButtons\LeftNormal.png", @"Buttons\GameButtons\LeftPress.png", @"Buttons\GameButtons\LeftFocus.png", 668, 278, "Pole22Tag");
            kontrolkaMenu = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 500, "MenuTag");
            kontrolkaExit = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 600, "ExitTag");

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    this.Controls.Add(pola[i, j]);
            this.Controls.Add(logo);
            this.Controls.Add(kontrolkaMenu);
            this.Controls.Add(kontrolkaExit);
            this.BackgroundImage = new Bitmap(@"Drawable\Wall_Beige.png");

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    pola[i, j].MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaMenu.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaExit.MouseClick += new MouseEventHandler(mouseClick);
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (((Kontrolka)sender).Tag.ToString())
                {
                    case "Pole00Tag":
                        upDate(0, 0);
                        break;

                    case "Pole01Tag":
                        upDate(0, 1);
                        break;

                    case "Pole02Tag":
                        upDate(0, 2);
                        break;

                    case "Pole10Tag":
                        upDate(1, 0);
                        break;

                    case "Pole11Tag":
                        upDate(1, 1);
                        break;

                    case "Pole12Tag":
                        upDate(1, 2);
                        break;

                    case "Pole20Tag":
                        upDate(2, 0);
                        break;

                    case "Pole21Tag":
                        upDate(2, 1);
                        break;

                    case "Pole22Tag":
                        upDate(2, 2);

                        break;

                    case "ExitTag":
                        Application.Exit();
                        break;

                    case "MenuTag":
                        Menu menu = new Menu();
                        menu.Tag = this;
                        menu.Show(this);
                        this.Hide();
                        break;

                }
            }
        }

        private void upDate(int x, int y)
        {
            int ruch = 3 * x + y + 1;
            gra.ruchGracza(nastepnyGracz, ruch);
            poleKomp = gra.ruchKomputera(!nastepnyGracz);
            wynik = gra.wygrana();
            runda.runda(wynik);

            if (gra.wygrana() != 0)
            {

                CzyNastepnaRundaKomputerForm czyNastepnaRundaKomputer = new CzyNastepnaRundaKomputerForm(runda, profile, gra, nastepnyGracz);
                czyNastepnaRundaKomputer.Tag = this;
                czyNastepnaRundaKomputer.Show(this);
                this.Hide();
            }

            int initialPositionX = pola[x, y].getPozycjaX();
            int initialPositionY = pola[x, y].getPozycjaY();
            int positionX = pola[poleKomp[0], poleKomp[1]].getPozycjaX();
            int positionY = pola[poleKomp[0], poleKomp[1]].getPozycjaY();
            pola[x, y].Dispose();
            pola[poleKomp[0], poleKomp[1]].Dispose();


            if (nastepnyGracz == false)
            {
                pola[x, y] = new Kontrolka(@"Buttons\GameButtons\UpNormal.png", @"Buttons\GameButtons\UpPress.png", @"Buttons\GameButtons\UpFocus.png", initialPositionX, initialPositionY, "Pole002Tag");
                pola[poleKomp[0], poleKomp[1]] = new Kontrolka(@"Buttons\GameButtons\DownNormal.png", @"Buttons\GameButtons\DownPress.png", @"Buttons\GameButtons\DownFocus.png", positionX, positionY, "Pole002Tag");
            }
            else
            {
                pola[x, y] = new Kontrolka(@"Buttons\GameButtons\DownNormal.png", @"Buttons\GameButtons\DownPress.png", @"Buttons\GameButtons\DownFocus.png", initialPositionX, initialPositionY, "Pole002Tag");
                pola[poleKomp[0], poleKomp[1]] = new Kontrolka(@"Buttons\GameButtons\UpNormal.png", @"Buttons\GameButtons\UpPress.png", @"Buttons\GameButtons\UpFocus.png", positionX, positionY, "Pole002Tag");
            }
            this.Controls.Add(pola[x, y]);
            this.Controls.Add(pola[poleKomp[0], poleKomp[1]]);
        }

        private void GraKomputerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
