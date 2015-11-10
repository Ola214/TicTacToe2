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
    public partial class NazwyGraczyForm : Form
    {
        private Kontrolka kontrolkaUser1;
        private Kontrolka kontrolkaUser2;
        private Kontrolka kontrolkaConfirm;
        private Kontrolka kontrolkaMenu;
        private Kontrolka kontrolkaExit;
        private TextBox user1Box;
        private TextBox user2Box;
        Gra gra;
        Profile pro;
        private Bitmap pngLogo;
        private PictureBox logo;

        public NazwyGraczyForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            this.DoubleBuffered = true;

            InitializeComponent();

            logo = new PictureBox();
            pngLogo = new Bitmap(@"Drawable\logoMsg.png");
            logo.BackColor = Color.Transparent;
            logo.Image = pngLogo;
            logo.Width = pngLogo.Width;
            logo.Height = pngLogo.Height;
            logo.Location = new Point(250, 20);

            gra = new Gra();
            pro = new Profile();

            kontrolkaUser1 = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", 200, 200, "ExitTag");
            user1Box = new TextBox();
            user1Box.Location = new Point(540,200);
            user1Box.AutoSize = false;
            user1Box.Size = new Size(600, kontrolkaUser1.Height);
            user1Box.Font = new Font(user1Box.Font.FontFamily, 32);
            kontrolkaUser2 = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitNormal.png", 200, 300, "ExitTag");
            user2Box = new TextBox();
            user2Box.Location = new Point(540, 300);
            user2Box.AutoSize = false;
            user2Box.Size = new Size(600, kontrolkaUser1.Height);
            user2Box.Font = new Font(user2Box.Font.FontFamily, 32);
            kontrolkaConfirm = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 400, "ConfirmTag");
            kontrolkaMenu = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 500, "MenuTag");
            kontrolkaExit = new Kontrolka(@"Buttons\MenuButtons\ExitNormal.png", @"Buttons\MenuButtons\ExitPress.png", @"Buttons\MenuButtons\ExitFocus.png", 540, 600, "ExitTag");

            this.Controls.Add(logo);
            this.Controls.Add(kontrolkaUser1);
            this.Controls.Add(kontrolkaUser2);
            this.Controls.Add(kontrolkaConfirm);
            this.Controls.Add(kontrolkaMenu);
            this.Controls.Add(kontrolkaExit);
            this.Controls.Add(user1Box);
            this.Controls.Add(user2Box);
            this.BackgroundImage = new Bitmap(@"Drawable\Wall_Beige.png");


            kontrolkaConfirm.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaMenu.MouseClick += new MouseEventHandler(mouseClick);
            kontrolkaExit.MouseClick += new MouseEventHandler(mouseClick);

        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (((Kontrolka)sender).Tag.ToString())
                {
                    case "ConfirmTag":
                        String user1Name = user1Box.Text;
                        String user2Name = user2Box.Text;
                        pro.setGracz1(user1Name);
                        pro.setGracz2(user2Name);
                        GraGraczForm graForm = new GraGraczForm(new Rundy(), pro, gra, false);
                        graForm.Tag = this;
                        graForm.Show(this);
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

        private void NazwyGraczyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
