using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel1
{
    public class Bierspecificatie : Drankspecificatie
    {
        public Bierspecificatie(Bierkleur? kleur, string brouwerij, Volume? volume, double? alcoholPercentage,
            string herkomstLand) : base(brouwerij,volume,alcoholPercentage,herkomstLand)
        {
            Kleur = kleur;
        }

        public Bierkleur? Kleur { get; private set; }
        

        public override bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {            
            if (!base.VoldoetAanSpecificatie(spec)) return false;
            if (spec.GetType() != typeof(Bierspecificatie)) return false;
            if (((Bierspecificatie)spec).Kleur != null && ((Bierspecificatie)spec).Kleur != this.Kleur) return false;
            return true;
        }

        public override string ToString()
        {
            return base.ToString()+ $",{Kleur} [BS]";
        }
    }
}
