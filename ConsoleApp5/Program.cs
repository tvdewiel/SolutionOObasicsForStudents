using DrankWinkel1;
using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Bier b1 = new Bier(1.05, "palm", Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, 6);
            //Bier b2 = new Bier(1.25, "rodenbach classic", "bruin", "palm", 25, 5.2, 6);
            //Bier b3 = new Bier(1.6, "leffe bruin", Bierkleur.Bruin, "", null, null, 6);
            //Bier b4 = new Bier(1.8, "duvel", "blond", "duvel moortgat", 33, 8.5, 4);
            Bierspecificatie b1 = new Bierspecificatie(Bierkleur.Amber, "palm", Volume.cl25, 5.2, "België");
            Bierspecificatie b2 = new Bierspecificatie(Bierkleur.Bruin, "palm", Volume.cl25, 5.2, "België");
            Bierspecificatie b3 = new Bierspecificatie(Bierkleur.Bruin, "leffe", Volume.cl33, 6.2, "België");
            Bierspecificatie b4 = new Bierspecificatie(Bierkleur.Blond, "duvel moortgat", Volume.cl33, 8.5, "België");
            Wijnspecificatie w1 = new Wijnspecificatie(Wijnkleur.rood, "Gato Negro", Volume.cl75, 12.5, "Chili");            
            Inventaris inventaris = new Inventaris();
            inventaris.VoegDrankToe(1.05, "palm",b1 , Setgrootte.zes);
            inventaris.VoegDrankToe(1.25, "rodenbach classic",b2 , Setgrootte.zes);
            inventaris.VoegDrankToe(1.6, "leffe bruin",b3 , Setgrootte.zes);
            inventaris.VoegDrankToe(1.8, "duvel",b4, Setgrootte.vier);
            inventaris.VoegDrankToe(5.8, "Gato Negro - merlot", w1, Setgrootte.een);
            //Drank x = inventaris.SelecteerDrank("palm");
            //Console.WriteLine($"Drank:{x}");
            //x = inventaris.SelecteerDrank("Gato Negro - merlot");
            //Console.WriteLine($"Drank:{x}");
            Bierspecificatie bierspec = new Bierspecificatie(Bierkleur.Bruin, null,null,null,null);
            List<Drank> ly = inventaris.ZoekDrank(bierspec);
            foreach (Drank y in ly)
                Console.WriteLine($"Drank:{y}");
            Console.WriteLine("------");
            Wijnspecificatie wijnspec = new Wijnspecificatie(Wijnkleur.rood, null,null,null, "Chili");
            List<Drank> lz = inventaris.ZoekDrank(wijnspec);
            foreach (Drank y in lz)
                Console.WriteLine($"Drank:{y}");
        }
    }
}
