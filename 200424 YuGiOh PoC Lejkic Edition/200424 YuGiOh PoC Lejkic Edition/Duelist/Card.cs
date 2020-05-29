using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _200424_YuGiOh_PoC_Lejkic_Edition.Duelist
{
    public enum Tip
    {
        Monster,
        EffectMonster,
        Spell,
        Trap
    }
    public enum Place
    {
        Main,
        Extra,
        Side
    }
    public class Card
    {
        public string Name { get; set; }
        public string Effect { get; set; }
        public Tip TipK { get; set; }
        public Place Lokacija { get; set; }
    }
}
