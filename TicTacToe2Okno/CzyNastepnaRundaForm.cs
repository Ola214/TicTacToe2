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
    public partial class CzyNastepnaRundaForm : Form
    {
        private Rundy runda;
        private Profile profile;
        private Gra gra;
        private bool nastepnyGracz;
        private Kontrolka kontrolkaRunda;
        private Kontrolka kontrolkaGraczKolko;
        private Kontrolka kontrolkaGraczKrzyzyk;
        private Kontrolka kontrolkaNastepnaRunda;
        private Kontrolka kontrolkaMenu;
        private Kontrolka kontrolkaExit;
        private Bitmap pngLogo;
        private PictureBox logo;
        private TextBox rundaBox;
        private TextBox kolkoBox;
        private TextBox krzyzykBox;


        public CzyNastepnaRundaForm(Rundy runda, Profile profile, Gra gra, bool nastepnyGracz)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            this.DoubleBuffered = true;

            InitializeComponent();

            // TODO: Complete member initialization
            this.runda = runda;
            this.profile = profile;
            this.gra = gra;
            this.nastepnyGracz = nastepnyGracz;

            logo = new PictureBox();
            pngLogo = new Bitmap(@"Drawable\logoMsg.png");
            logo.BackColor = Color.Transparent;
            logo.Image = pngLogo;
            logo.Width = pngLogo.Width;
            logo.Height = pngLogo.Height;
            logo.Location = new Point(250, 20);

            kontrolkaRunda = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", 200, 150, "RundaTag");
            kontrolkaGraczKolko = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", 200, 250, "GraczKolkoTag");
            kontrolkaGraczKrzyzyk = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", 200, 350, "GraczKrzyzykTag");
            kontrolkaNastepnaRunda = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 450, "NastepnaRundaTag");
            kontrolkaMenu = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 550, "MenuTag");
            kontrolkaExit = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 650, "ExitTag");

            rundaBox = new TextBox();
            rundaBox.Location = new Point(540, 150);
            rundaBox.AutoSize = false;
            rundaBox.Size = new Size(600, kontrolkaRunda.Height);
            rundaBox.Font = new Font(rundaBox.Font.FontFamily, 32);
            rundaBox.AppendText(runda.getLicznikRund().ToString());

            kolkoBox = new TextBox();
            kolkoBox.Location = new Point(540, 250);
            kolkoBox.AutoSize = false;
            kolkoBox.Size = new Size(600, kontrolkaRunda.Height);
            kolkoBox.Font = new Font(kolkoBox.Font.FontFamily, 32);
            kolkoBox.AppendText(profile.getGracz2().ToString() + " " + runda.getLicznikKolko());

            krzyzykBox = new TextBox();
            krzyzykBox.Location = new Point(540, 350);
            krzyzykBox.AutoSize = false;
            krzyzykBox.Size = new Size(600, kontrolkaRunda.Height);
            krzyzykBox.Font = new Font(rundaBox.Font.FontFamily, 32);
            krzyzykBox.AppendText(profile.getGracz1().ToString() + " " + runda.getLicznikKrzyzyk());


            this.Controls.Add(rundaBox);
            this.Controls.Add(kolkoBox);
            this.Controls.Add(krzyzykBox);
            this.Controls.Add(kontrolkaRunda);
            this.Controls.Add(kontrolkaGraczKolko);
            this.Controls.Add(kontrolkaGraczKrzyzyk);
            this.Controls.Add(kontrolkaNastepnaRunda);
            this.Controls.Add(kontrolkaMenu);
            this.Controls.Add(kontrolkaExit);
            this.Controls.Add(logo);
            this.BackgroundImage = new Bitmap(@"Drawable\Wall_Beige.png");

            kontrolkaRunda.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaGraczKolko.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaGraczKrzyzyk.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaNastepnaRunda.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaMenu.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaExit.MouseClick += new MouseEventHandler(mouseClick);
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (((Kontrolka)sender).Tag.ToString())
                {
                   
                    case "NastepnaRundaTag":
                        GraGraczForm graGracz = new GraGraczForm(runda, profile, new Gra(), nastepnyGracz);
                        graGracz.Tag = this;
                        graGracz.Show(this);
                        this.Hide();
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

        private void CzyNastepnaRundaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
