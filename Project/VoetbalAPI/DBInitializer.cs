using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoetbalAPI
{
    public class DBInitializer
    {
        public static void Initialize(CompetitieContext context)
        {
            Ploeg RSCAnderlecht = new Ploeg() { PloegNaam = "RSC Anderlecht", Gemeente = "Anderlecht",Website = "https://www.rsca.be/nl", Email="", Stamnummer = 35, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Ploeg RoyalAntwerpFC = new Ploeg() { PloegNaam = "Royal Antwerp FC", Gemeente = "Antwerpen", Website = "https://royalantwerpfc.be/", Email = "", Stamnummer = 1, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Ploeg CercleBrugge = new Ploeg() {PloegNaam = "Cercle Brugge", Gemeente = "Brugge", Website = "https://www.cerclebrugge.be/nl/", Email = "", Stamnummer = 12,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0 };
            Ploeg ClubBrugge = new Ploeg() { PloegNaam = "Club Brugge", Gemeente = "Brugge", Website = "https://www.clubbrugge.be/nl", Email = "", Stamnummer = 3, Gewonnen = 0, Verloren = 0, Gelijkspel = 0,Punten = 0  };
            Ploeg RoyalCharleroiSportingClub = new Ploeg() { PloegNaam = "Royal Charleroi Sporting Club", Gemeente = "Charleroi", Website = "https://www.sporting-charleroi.be/", Email = "", Stamnummer = 22,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0 };
            Ploeg KASEupen = new Ploeg(){PloegNaam = "KAS Eupen",Gemeente = "Eupen", Website = "https://www.as-eupen.be/", Email = "", Stamnummer = 4276,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Ploeg KRCGenk = new Ploeg() {PloegNaam = "KRC Genk",Gemeente = "Genk", Website = "https://www.krcgenk.be/nl", Email = "", Stamnummer = 322,Gewonnen = 0, Verloren = 0,Gelijkspel = 0,Punten = 0};
            Ploeg KAAGent = new Ploeg(){ PloegNaam = "KAA Gent",Gemeente = "Gent", Website = "https://www.kaagent.be/nl", Email = "", Stamnummer = 7,Gewonnen = 0,Verloren = 0, Gelijkspel = 0,Punten = 0};
            Ploeg KVKortrijk = new Ploeg {PloegNaam = "KV Kortrijk",Gemeente = "Kortrijk", Website = "https://kvk.be/", Email = "", Stamnummer = 19,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Ploeg KVMechelen = new Ploeg {PloegNaam = "KV Mechelen",Gemeente = "Mechelen", Website = "https://www.kvmechelen.be/", Email = "", Stamnummer = 25,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Ploeg RoyalExcelMoeskroen = new Ploeg(){PloegNaam = "Royal Excel Moeskroen",Gemeente = "Moeskroen", Website = "https://www.excel-foot.be/", Email = "", Stamnummer = 216,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Ploeg KVOostende = new Ploeg(){PloegNaam = "KV Oostende",Gemeente = "Oostende", Website = "https://www.kvo.be/", Email = "", Stamnummer = 31,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Ploeg SintTruidenseVV = new Ploeg() { PloegNaam = "Sint-Truidense VV", Gemeente = "Sint-Truiden", Website = "https://www.stvv.com/nl", Email = "", Stamnummer = 373, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Ploeg StandardLuik = new Ploeg() { PloegNaam = "Standard Luik", Gemeente = "Luik", Website = "https://standard.be/nl", Email = "", Stamnummer = 16, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Ploeg KVRSWaaslandSKBeveren = new Ploeg() { PloegNaam = "KVRS Waasland - SK Beveren", Website = "https://www.waasland-beveren.be/", Email = "", Gemeente = "Beveren", Stamnummer = 4068, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Ploeg SVZulteWaregem = new Ploeg() { PloegNaam = "SV Zulte Waregem", Gemeente = "Waregem", Website = "https://www.essevee.be/nl", Email = "", Stamnummer = 5381, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };


            Speler SinanBolat = new Speler() { PloegNaam = "Royal Antwerp FC", Voornaam = "Sinan", Achternaam = "Bolat", Woonplaats = "Merksem", Positie = "keeper", Rugnummer = 1, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            Speler DieumerciMbokani  = new Speler() { PloegNaam = "Royal Antwerp FC", Voornaam = "Dieumerci", Achternaam = "Mbokani", Woonplaats = "Merksem", Positie = "Aanvaller", Rugnummer = 70, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            Speler HansVanaken = new Speler() { PloegNaam = "Club Brugge", Voornaam = "Hans", Achternaam = "Vanaken", Woonplaats = "Brugge", Positie = "Middenvelder", Rugnummer = 20, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            Speler AleksandarVukotic = new Speler() { PloegNaam = "KVRS Waasland - SK Beveren", Voornaam = "Aleksandar", Achternaam = "Vukotic", Woonplaats = "Antwerpen", Positie = "Verdediger", Rugnummer = 26, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            context.Database.EnsureCreated();

            if (!context.Ploegen.Any())
            {
                context.Ploegen.Add(RSCAnderlecht);
                context.Ploegen.Add(RoyalAntwerpFC);
                context.Ploegen.Add(CercleBrugge);
                context.Ploegen.Add(ClubBrugge);
                context.Ploegen.Add(RoyalCharleroiSportingClub);
                context.Ploegen.Add(KASEupen);
                context.Ploegen.Add(KRCGenk);
                context.Ploegen.Add(KAAGent);
                context.Ploegen.Add(KVKortrijk);
                context.Ploegen.Add(KVMechelen);
                context.Ploegen.Add(RoyalExcelMoeskroen);
                context.Ploegen.Add(KVOostende);
                context.Ploegen.Add(SintTruidenseVV);
                context.Ploegen.Add(StandardLuik);
                context.Ploegen.Add(KVRSWaaslandSKBeveren);
                context.Ploegen.Add(SVZulteWaregem);
                context.SaveChanges();
            }

            if (!context.Spelers.Any())
            {
                context.Spelers.Add(SinanBolat);
                context.Spelers.Add(DieumerciMbokani);
                context.Spelers.Add(HansVanaken);
                context.Spelers.Add(AleksandarVukotic);
                context.SaveChanges();
            }
        }
    }
}
