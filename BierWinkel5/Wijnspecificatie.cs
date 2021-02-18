namespace DrankWinkel1
{
    public class Wijnspecificatie : Drankspecificatie
    {
        public Wijnspecificatie(Wijnkleur? kleur, string brouwerij, Volume? volume, double? alcoholPercentage,
            string herkomstLand) : base(brouwerij, volume, alcoholPercentage, herkomstLand)
        {
            Kleur = kleur;
        }

        public Wijnkleur? Kleur { get; private set; }
        public override bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            if (!base.VoldoetAanSpecificatie(spec)) return false;
            if (spec.GetType() != typeof(Wijnspecificatie)) return false;
            if (((Wijnspecificatie)spec).Kleur != null && ((Wijnspecificatie)spec).Kleur != this.Kleur) 
                return false;
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $",{Kleur} [WS]";
        }
    }
}