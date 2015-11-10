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
    public partial class Menu : Form
    {
        RankingForm ranking;
        private Kontrolka kontrolkaNowaGraKomputer;
        private Kontrolka kontrolkaNowaGraGracz;
        private Kontrolka kontrolkaRanking;
        private Kontrolka kontrolkaExit;
        private Bitmap pngLogo;
        private PictureBox logo;
        //SoundPlayer typewriter;

        public Menu()
        {
            //Enable full screen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            this.DoubleBuffered = true;

            InitializeComponent();

            logo = new PictureBox();
            pngLogo = new Bitmap(@"Drawable\logoMenu.png");
            logo.BackColor = Color.Transparent;
            logo.Image = pngLogo;
            logo.Width = pngLogo.Width;
            logo.Height = pngLogo.Height;
            logo.Location = new Point(250, 20);

            kontrolkaNowaGraKomputer = new Kontrolka(@"Buttons\MenuButtons\NewGameNormal.png", @"Buttons\MenuButtons\NewGamePress.png", @"Buttons\MenuButtons\NewGameFocus.png", 450, 350, "NewGameComputerTag");
            kontrolkaNowaGraGracz = new Kontrolka(@"Buttons\MenuButtons\NewGameNormal.png", @"Buttons\MenuButtons\NewGamePress.png", @"Buttons\MenuButtons\NewGameFocus.png", 450, 450, "NewGameTag");
            kontrolkaRanking = new Kontrolka(@"Buttons\MenuButtons\RankingNormal.png", @"Buttons\MenuButtons\RankingPress.png", @"Buttons\MenuButtons\RankingFocus.png", 480, 550, "RankingTag");
            kontrolkaExit = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 650, "ExitTag");

            this.Controls.Add(logo);
            this.Controls.Add(kontrolkaNowaGraKomputer);
            this.Controls.Add(kontrolkaNowaGraGracz);
            this.Controls.Add(kontrolkaRanking);
            this.Controls.Add(kontrolkaExit);
            this.BackgroundImage = new Bitmap(@"Drawable\Wall_Beige.png");

            kontrolkaNowaGraKomputer.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaNowaGraGracz.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaRanking.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaExit.MouseClick += new MouseEventHandler(mouseClick);
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (((Kontrolka)sender).Tag.ToString())
                {
                    case "RankingTag":
                        if (ranking == null)
                        {
                            ranking = new RankingForm();
                            ranking.Tag = this;
                        }
                        ranking.Show(this);
                        this.Hide();
                        break;

                    case "ExitTag":
                        Application.Exit();
                        break;

                    case "NewGameComputerTag":

                        NazwaGraczaForm graKomputer = new NazwaGraczaForm();
                        graKomputer.Tag = this;
                        graKomputer.Show(this);
                        this.Hide();
                        break;

                    case "NewGameTag":

                        NazwyGraczyForm graGracz = new NazwyGraczyForm();
                        graGracz.Tag = this;
                        graGracz.Show(this);
                        this.Hide();
                        break;
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

       
    }
}
