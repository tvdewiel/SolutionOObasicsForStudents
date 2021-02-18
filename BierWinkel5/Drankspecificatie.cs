using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel1
{
    public abstract class Drankspecificatie
    {
        protected Drankspecificatie(string brouwerij, Volume? volume, double? alcoholPercentage, string herkomstLand)
        {
            Brouwerij = brouwerij;
            Volume = volume;
            if (alcoholPercentage < 0) throw new Exception("percentage kan niet kleiner zijn dan 0");
            AlcoholPercentage = alcoholPercentage;
            HerkomstLand = herkomstLand;
        }

        public string Brouwerij { get; private set; }
        public Volume? Volume { get; private set; }
        public double? AlcoholPercentage { get; private set; }
        public string HerkomstLand { get; private set; }
        public virtual bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            bool ok = true;           
            if (spec.Brouwerij != null && spec.Brouwerij.Length > 0
                && spec.Brouwerij.ToLower() != this.Brouwerij.ToLower()) ok = false;
            if (spec.Volume != null && spec.Volume != this.Volume) ok = false;
            if (spec.AlcoholPercentage != null && spec.AlcoholPercentage != this.AlcoholPercentage) ok = false;
            if (spec.HerkomstLand != null && spec.HerkomstLand != this.HerkomstLand) ok = false;
            return ok;
        }
        public override string ToString()
        {
            return $"[DS] {Brouwerij},{Volume},{AlcoholPercentage},{HerkomstLand}";
        }
    }
}
