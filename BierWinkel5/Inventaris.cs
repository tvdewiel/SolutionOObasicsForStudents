using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel1
{
    /*
    matchen specificatie gedelegeerd naar bierspec
     */
    public class Inventaris
    {
        private Dictionary<string,Drank> Dranken = new Dictionary<string, Drank>();
        public void VoegDrankToe(double prijsPerStuk, string naam, Drankspecificatie drankspecifikatie,
            Setgrootte minimumHoeveelheid)
        {
            Drank drank = new Drank(prijsPerStuk, naam, minimumHoeveelheid, drankspecifikatie);
            if (!Dranken.ContainsKey(naam)) Dranken.Add(drank.Naam, drank);
        }
        public Drank SelecteerDrank(string naam)
        {
            if (Dranken.ContainsKey(naam)) return Dranken[naam];
            return null;
        }
        public List<Drank> ZoekDrank(Drankspecificatie drank)
        {
            List<Drank> gevondenDranken = new List<Drank>();
            foreach (Drank d in Dranken.Values)
            {
                if (d.Drankspecificatie.VoldoetAanSpecificatie(drank)) gevondenDranken.Add(d);
            }
            return gevondenDranken;
        }
    }
}
