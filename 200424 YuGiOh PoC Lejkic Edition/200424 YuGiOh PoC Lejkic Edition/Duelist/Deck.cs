using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200424_YuGiOh_PoC_Lejkic_Edition.Duelist
{
    public class Deck
    {
        public string Name { get; set; }
        public List<Card> Main { get; set; }
        public List<Card> Extra { get; set; }
    }
}
