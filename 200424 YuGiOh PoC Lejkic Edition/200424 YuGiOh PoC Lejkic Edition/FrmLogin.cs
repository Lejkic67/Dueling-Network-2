using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _200424_YuGiOh_PoC_Lejkic_Edition.Duelist;
using System.Xml.Serialization;
using System.IO;

namespace _200424_YuGiOh_PoC_Lejkic_Edition
{
    public partial class FrmLogIn : Form
    {
        public static void Save(List<Igrac> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Igrac>));
            using (TextWriter writer = new StreamWriter("Duelists.xml"))
            {
                serializer.Serialize(writer, list);
            }
        }

        public static List<Igrac> LoadFromFile()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Igrac>));
            TextReader reader = new StreamReader(@"Duelists.xml");
            object obj = deserializer.Deserialize(reader);
            List<Igrac> XmlData = (List<Igrac>)obj;
            reader.Close();
            return XmlData;
        }

        List<Igrac> duelists = new List<Igrac>();

        public FrmLogIn()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            duelists = LoadFromFile();
            
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtEmail.Text == "Username")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Username";
                txtEmail.ForeColor = Color.Gray;
            }
        }
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp sU = new FrmSignUp();
            sU.Show();
        }

        bool ProveraUsername()
        {
            List<string> usernames = new List<string>();

            foreach (Igrac duelist in duelists)
            {
                usernames.Add(duelist.Username);
            }

            if(usernames.Contains(txtEmail.Text) == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username ne postoji");
                return false;
            }
        }

        bool ProveraPassword()
        {
            foreach(Igrac duelist in duelists)
            {
                if(duelist.Username == txtEmail.Text)
                {
                    if(txtPassword.Text == duelist.Password)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Password nije ispravan");
                        return false;
                    }
                }
            }
            return false;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            duelists = LoadFromFile();
            if (ProveraUsername() == true)
            {
                if(ProveraPassword() == true)
                {
                    Igrac igrac = new Igrac();
                    igrac.Username = txtEmail.Text;
                    igrac.Password = txtPassword.Text;
                    this.Hide();
                    FrmStartUp sU = new FrmStartUp(igrac);
                    sU.ShowDialog();
                    this.Close();
                }
            }
        }

        private void cBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
