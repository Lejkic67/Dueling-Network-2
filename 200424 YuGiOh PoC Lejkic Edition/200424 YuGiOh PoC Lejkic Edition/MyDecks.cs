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
    public partial class FrmMyDecks : Form
    {
        static public void SaveCards(List<Card> details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));
            using (TextWriter writer = new StreamWriter(@"AllCards.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }

        public static List<Card> LoadFromFileCards()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Card>));
            TextReader reader = new StreamReader(@"AllCards.xml");
            object obj = deserializer.Deserialize(reader);
            List<Card> XmlData = (List<Card>)obj;
            reader.Close();
            return XmlData;
        }

        private void Ispuni()
        {
            ilSve.ImageSize = new Size(75, 110);
          
            String[] paths = { };
            paths = Directory.GetFiles("Karte");

            try
            {
                foreach(String path in paths)
                {
                    ilSve.Images.Add(Image.FromFile(path));
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            lvSve.SmallImageList = ilSve;
            lvSve.Items.Add("Ancient Elf", 0);
            lvSve.Items.Add("Baby Dragon", 1);
            lvSve.Items.Add("Battle Ox", 2);
            lvSve.Items.Add("Beaver Warrior", 3);
            lvSve.Items.Add("Big Eye", 4);
            lvSve.Items.Add("Block Attack", 5);
            lvSve.Items.Add("BlueEyes Ultimate Dragon", 6);
            lvSve.Items.Add("BlueEyes White Dragon", 7);
            lvSve.Items.Add("Celtic Guardian", 8);
            lvSve.Items.Add("Change of Heart", 9);
            lvSve.Items.Add("Curse of Dragon", 10);
            lvSve.Items.Add("Dark Assailant", 11);
            lvSve.Items.Add("Dark Energy", 12);
            lvSve.Items.Add("Dark Hole", 13);
            lvSve.Items.Add("Dark Magician", 14);
            lvSve.Items.Add("Dark Paladin", 15);
            lvSve.Items.Add("De Spell", 16);
            lvSve.Items.Add("Dian Keto the Cure Master", 17);
            lvSve.Items.Add("Doma The Angel of  Silence", 18);
            lvSve.Items.Add("Feral Imp", 19);
            lvSve.Items.Add("Gaia The Fierce Knight", 20);
            lvSve.Items.Add("Giant Soldier of Stone", 21);
            lvSve.Items.Add("Hane Hane", 22);
            lvSve.Items.Add("JudgeMan", 23);
            lvSve.Items.Add("Just Desserts", 24);
            lvSve.Items.Add("Koumori Dragon", 25);
            lvSve.Items.Add("La Jinn the Mystical Genie of the Lamp", 26);
            lvSve.Items.Add("Masaki the Legendary Swordsman", 27);
            lvSve.Items.Add("Monster Reborn", 28);
            lvSve.Items.Add("Mountain", 29);
            lvSve.Items.Add("Mystic Clown", 30);
            lvSve.Items.Add("Mystic Horseman", 31);
            lvSve.Items.Add("Mystical Elf", 32);
            lvSve.Items.Add("Ogre of the Black Shadow", 33);
            lvSve.Items.Add("RedEyes B Dragon", 34);
            lvSve.Items.Add("Rude Kaiser", 35);
            lvSve.Items.Add("Ryu Kishin Powered", 36);
            lvSve.Items.Add("Ryu Kishin", 37);
            lvSve.Items.Add("Scapegoat", 38);
            lvSve.Items.Add("Seven Tools of the Bandit", 39);
            lvSve.Items.Add("Summoned Skull", 40);
            lvSve.Items.Add("Swordstalker", 41);
            lvSve.Items.Add("Time Wizard", 42);
            lvSve.Items.Add("Trap Hole", 43);
            lvSve.Items.Add("Ultimate Offering", 44);
            lvSve.Items.Add("Waboku", 45);
            lvSve.Items.Add("Yami", 46);
        }
        public static void SaveDeck(List<Deck> deck)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Deck>));
            using (TextWriter writer = new StreamWriter("Decks.xml"))
            {
                serializer.Serialize(writer, deck);
            }
        }

        public static List<Deck> LoadDeckFromFile()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Deck>));
            TextReader reader = new StreamReader(@"Decks.xml");
            object obj = deserializer.Deserialize(reader);
            List<Deck> XmlData = (List<Deck>)obj;
            reader.Close();
            return XmlData;
        }
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


        List<Card> allCards = new List<Card>();
        List<Card> mainDeck = new List<Card>();
        List<Card> extraDeck = new List<Card>();
        List<Igrac> duelists = new List<Igrac>();
        Igrac igrac = new Igrac();

        List<Deck> deckovi = new List<Deck>();

        public FrmMyDecks(Igrac igrac1)
        {
            InitializeComponent();

            duelists = LoadFromFile();

            foreach(Igrac player in duelists)
            {
                if(igrac1.Username == player.Username)
                {
                    igrac1 = player;
                }
            }

            igrac = igrac1;
            cbDeckovi.DisplayMember = "Name";
            deckovi = LoadDeckFromFile();

            foreach (Deck deck in deckovi)
            {
                if (deck.Name.Contains(igrac.Username)) 
                    cbDeckovi.Items.Add(deck);
            }

            lbMain.DisplayMember = "Name";
            lbExtra.DisplayMember = "Name";

            lvSve.View = View.Details;
            allCards = LoadFromFileCards();

            lvSve.Columns.Add("Cards :", 150);
            lvSve.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            Ispuni();

        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                Ispuni();
            }
            else
            {
                lvSve.Items.Clear();
                ilSearch.Images.Clear();
                ilSearch.ImageSize = new Size(75, 110);

                String[] paths = { };
                paths = Directory.GetFiles("Karte");

                if(paths.Contains(tbSearch.Text)){
                    try
                    {
                        foreach (String path in paths)
                        {
                            ilSearch.Images.Add(Image.FromFile(path));
                            lvSve.SmallImageList = ilSearch;
                        }
                    }
                    catch (Exception c)
                    {
                        MessageBox.Show(c.Message);
                    }
                }

                foreach (Card card in allCards)
                {
                    int i = 0;
                    if (card.Name.Contains(tbSearch.Text))
                    {
                        lvSve.Items.Add($"{card.Name}", i);
                        i++;
                    }
                }
            }
        }

        public void lvSve_MouseClick(object sender, MouseEventArgs e)
        {
            String[] paths = { };
            paths = Directory.GetFiles("Karte");

            foreach (String path in paths)
            {
                if (path.Contains(lvSve.SelectedItems[0].Text))
                    pbSelCard.Image = Image.FromFile(path);
            }

            foreach(Card card in allCards)
            {
                if(card.Name == lvSve.SelectedItems[0].Text)
                {
                    lblCardName.Text = card.Name;
                    rtbSelCardInfo.Text = $"[{card.TipK}]{Environment.NewLine}{card.Effect}";
                }
            }
        }

        private void lvSve_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (Card card in allCards)
            {
                if (card.Name == lvSve.SelectedItems[0].Text)
                {
                    if(card.Lokacija == Place.Main)
                    {
                        if (lbMain.Items.Contains(card))
                        {
                            MessageBox.Show("Ne mogu biti dve iste karte u decku");
                        }
                        else
                        {
                            lbMain.Items.Add(card);
                            mainDeck.Add(card);
                        }
                    }
                    if(card.Lokacija == Place.Extra)
                    {
                        if (lbExtra.Items.Contains(card))
                        {
                            MessageBox.Show("Ne mogu biti dve iste karte u decku");
                        }
                        else
                        {
                            lbExtra.Items.Add(card);
                            extraDeck.Add(card);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.Main = mainDeck;
            deck.Extra = extraDeck;
            deck.Name = $"{igrac.Username}.{tbNameDeck.Text}";
            deckovi.Add(deck);
            SaveDeck(deckovi);

            lbMain.Items.Clear();
            lbExtra.Items.Clear();

            cbDeckovi.Items.Clear();
            foreach (Deck spil in deckovi)
            {
                if (spil.Name.Contains(igrac.Username))
                    cbDeckovi.Items.Add(spil);
            }
        }

        private void lbExtra_MouseClick(object sender, MouseEventArgs e)
        {
            String[] paths = { };
            paths = Directory.GetFiles("Karte");

            foreach (String path in paths)
            {
                if (path.Contains(lbExtra.GetItemText(lbExtra.SelectedItem)))
                    pbSelCard.Image = Image.FromFile(path);
            }

            foreach (Card card in allCards)
            {
                if (card.Name == lbExtra.GetItemText(lbExtra.SelectedItem))
                {
                    lblCardName.Text = card.Name;
                    rtbSelCardInfo.Text = $"[{card.TipK}]{Environment.NewLine}{card.Effect}";
                }
            }
        }

        private void lbExtra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbExtra.Items.Remove(lbExtra.SelectedItem);
            foreach(Card card in extraDeck)
            {
                if(card.Name == lbExtra.GetItemText(lbExtra.SelectedItem))
                    extraDeck.Remove(card);
            }
            
        }

        private void lbMain_MouseClick(object sender, MouseEventArgs e)
        {
            String[] paths = { };
            paths = Directory.GetFiles("Karte");

            foreach (String path in paths)
            {
                if (path.Contains(lbMain.GetItemText(lbMain.SelectedItem)))
                    pbSelCard.Image = Image.FromFile(path);
            }

            foreach (Card card in allCards)
            {
                if (card.Name == lbMain.GetItemText(lbMain.SelectedItem))
                {
                    lblCardName.Text = card.Name;
                    rtbSelCardInfo.Text = $"[{card.TipK}]{Environment.NewLine}{card.Effect}";
                }
            }
        }

        private void lbMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbMain.Items.Remove(lbMain.SelectedItem);
            foreach (Card card in mainDeck)
            {
                if (card.Name == lbMain.GetItemText(lbMain.SelectedItem))
                    mainDeck.Remove(card);
            }
        }

        private void cbDeckovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMain.Items.Clear();
            lbExtra.Items.Clear();
            deckovi = LoadDeckFromFile();
            foreach(Deck deck in deckovi)
            {
                if (deck.Name.Contains(cbDeckovi.GetItemText(cbDeckovi.SelectedItem)))
                {
                    foreach(Card card in deck.Main)
                    {
                        lbMain.Items.Add(card);
                    }
                    foreach (Card card in deck.Extra)
                    {
                        lbExtra.Items.Add(card);
                    }
                }
            }
        }
    }
}
