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
    public partial class GraGraczForm : Form
    {
        Rundy runda;
        Gra gra;
        Boolean nastepnyGracz;
        int wynik;
        Profile profile;

        public GraGraczForm(Rundy runda, Profile profile, Gra gra, Boolean nastepnyGracz)
        {
            InitializeComponent();
            this.runda = runda;
            this.gra = gra;
            this.nastepnyGracz = nastepnyGracz;
            this.profile = profile;
        }
    }
}
