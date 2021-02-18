using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel1
{
    public class Drank
    {
        public Drank(double prijsPerStuk, string naam, Setgrootte minimumHoeveelheid, Drankspecificatie drankspecificatie)
        {
            if (prijsPerStuk <= 0) throw new Exception("prijs moet groter zijn dan 0");
            PrijsPerStuk = prijsPerStuk;
            if (string.IsNullOrWhiteSpace(naam)) throw new Exception("naam mag niet leeg zijn");
            Naam = naam;
            MinimumHoeveelheid = minimumHoeveelheid;
            Drankspecificatie = drankspecificatie;
        }

        public double PrijsPerStuk { get; private set; }
        public string Naam { get; private set; }
        public Setgrootte MinimumHoeveelheid { get; private set; }
        public Drankspecificatie Drankspecificatie { get; private set; }

        public override string ToString()
        {
            return $"[Drank] {PrijsPerStuk},{Naam},{MinimumHoeveelheid},{Drankspecificatie}";
        }
    }
}
