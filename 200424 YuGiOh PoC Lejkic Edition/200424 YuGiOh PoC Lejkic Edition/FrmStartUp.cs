using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using _200424_YuGiOh_PoC_Lejkic_Edition.Duelist;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200424_YuGiOh_PoC_Lejkic_Edition
{
    public partial class FrmStartUp : Form
    {

        FrmLogIn frmLog = new FrmLogIn();
        
        public FrmStartUp(Igrac duelist)
        {
            InitializeComponent();
            Igrac igrac = new Igrac();
            igrac = duelist;
            lblUser.Text = igrac.Username;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLog.ShowDialog();
            this.Close();
        }

        private void btnDeck_Click(object sender, EventArgs e)
        {

            Igrac igrac = new Igrac();
            igrac.Username = lblUser.Text;
            FrmMyDecks frmDecks = new FrmMyDecks(igrac);
            frmDecks.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://duelingnexus.com/home");
        }
    }
}
