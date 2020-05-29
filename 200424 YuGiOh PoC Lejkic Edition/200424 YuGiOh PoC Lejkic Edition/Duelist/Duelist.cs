using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace _200424_YuGiOh_PoC_Lejkic_Edition.Duelist
{
    public class Igrac
    { 
        public string Username { get; set; }
        public string Password { get; set; }

        List<Deck> decks;
    }
}
