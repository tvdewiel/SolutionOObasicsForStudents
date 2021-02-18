using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel1
{
    /* 
     */
    public class Bier : Drank
    {
        public Bier(double prijsPerStuk, string naam, Bierspecificatie bierspecifikatie, Setgrootte minimumHoeveelheid)
            : base(prijsPerStuk,naam,minimumHoeveelheid, bierspecifikatie)
        {
        }
        public override string ToString()
        {
            return "[Bier]"+base.ToString();
        }
    }
}
