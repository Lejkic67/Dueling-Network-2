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
    public partial class FrmSignUp : Form
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
        
        public FrmSignUp()
        {
            InitializeComponent();
            duelists = LoadFromFile();
            txtPass.UseSystemPasswordChar = true;
            txtConPass.UseSystemPasswordChar = true;
            cbShowPass.Checked = true;
            cBShowConPass.Checked = true;
        }
        
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtConPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConPass.Text == "Confirm Password")
            {
                txtConPass.Text = "";
                txtConPass.ForeColor = Color.Black;
            }
        }

        private void txtConPass_Leave(object sender, EventArgs e)
        {
            if (txtConPass.Text == "")
            {
                txtConPass.Text = "Confirm Password";
                txtConPass.ForeColor = Color.Gray;
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void cBShowConPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBShowConPass.Checked)
            {
                txtConPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtConPass.UseSystemPasswordChar = true;
            }
        }

        bool ProveraUsername()
        {
            foreach(Igrac duelist in duelists)
            {
                if(txtUsername.Text == duelist.Username)
                {
                    MessageBox.Show("Username je zauzet");
                    return false;
                }
            }
            if(txtUsername.Text.Length <= 3)
            {
                MessageBox.Show("Username mora biti duzi od 3 karaktera");
                return false;
            }
            if(txtUsername.Text.Length >= 20)
            {
                MessageBox.Show("Username mora biti kraci od 20 karaktera");
                return false;
            }
            else
            {
                return true;
            }
        }

        bool ProveraPassword()
        {
            if (txtPass.Text.Length <= 7)
            {
                MessageBox.Show("Password mora biti duzi od 7 karaktera");
                return false;
            }
            if (txtPass.Text.Any(char.IsUpper) == false)
            {
                MessageBox.Show("Password mora sadrzati bar jedno veliko slovo");
                return false;
            }
            if (txtPass.Text.Any(char.IsLower) == false)
            {
                MessageBox.Show("Password mora sadrzati bar jedno malo slovo");
                return false;
            }
            if (txtPass.Text.Any (char.IsDigit) == false)
            {
                MessageBox.Show("Password mora sadrzati bar jedan broj");
                return false;
            }
            else
            {
                return true;
            }
        }

        bool ProveraConfirma()
        {
            if(txtConPass.Text != txtPass.Text)
            {
                MessageBox.Show("Passwordi se ne podudaraju");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(ProveraUsername() == true)
            {
                if(ProveraPassword() == true)
                {
                    if(ProveraConfirma() == true)
                    {
                        Igrac duelist = new Igrac();
                        duelist.Username = txtUsername.Text;
                        duelist.Password = txtPass.Text;
                        duelists.Add(duelist);
                        Save(duelists);

                        MessageBox.Show($"Uspesno ste kreirali nalog.{Environment.NewLine}Vreme je za dvoboj!");

                        this.Close();
                    }
                }
            }
        }
    }
}
