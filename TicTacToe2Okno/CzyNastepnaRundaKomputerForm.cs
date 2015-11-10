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
    public partial class CzyNastepnaRundaKomputerForm : Form
    {
        private Rundy runda;
        private Profile profile;
        private GraKomputer gra;
        private bool nastepnyGracz;

        public CzyNastepnaRundaKomputerForm()
        {
            InitializeComponent();
        }

        public CzyNastepnaRundaKomputerForm(Rundy runda, Profile profile, GraKomputer gra, bool nastepnyGracz)
        {
            // TODO: Complete member initialization
            this.runda = runda;
            this.profile = profile;
            this.gra = gra;
            this.nastepnyGracz = nastepnyGracz;
        }
    }
}
