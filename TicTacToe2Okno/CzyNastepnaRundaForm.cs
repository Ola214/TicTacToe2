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

        public CzyNastepnaRundaForm()
        {
            InitializeComponent();
        }

        public CzyNastepnaRundaForm(Rundy runda, Profile profile, Gra gra, bool nastepnyGracz)
        {
            // TODO: Complete member initialization
            this.runda = runda;
            this.profile = profile;
            this.gra = gra;
            this.nastepnyGracz = nastepnyGracz;
        }
    }
}
