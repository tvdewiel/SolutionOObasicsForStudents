using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel1
{
    public class Wijn : Drank
    {
        public Wijn(double prijsPerStuk, string naam, Wijnspecificatie wijnspecifikatie, Setgrootte minimumHoeveelheid)
           : base(prijsPerStuk, naam, minimumHoeveelheid,wijnspecifikatie)
        {
        }
        public override string ToString()
        {
            return "[Wijn]"+base.ToString();
        }
    }
}
