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
            Model.Ploeg RSCAnderlecht = new Model.Ploeg() { PloegNaam = "RSC Anderlecht", Gemeente = "Anderlecht",Website = "https://www.rsca.be/nl", Stamnummer = 35, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Model.Ploeg RoyalAntwerpFC = new Model.Ploeg() { PloegNaam = "Royal Antwerp FC", Gemeente = "Antwerpen", Website = "https://royalantwerpfc.be/", Stamnummer = 1, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Model.Ploeg CercleBrugge = new Model.Ploeg() {PloegNaam = "Cercle Brugge", Gemeente = "Brugge", Website = "https://www.cerclebrugge.be/nl/", Stamnummer = 12,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0 };
            Model.Ploeg ClubBrugge = new Model.Ploeg() { PloegNaam = "Club Brugge", Gemeente = "Brugge", Website = "https://www.clubbrugge.be/nl", Stamnummer = 3, Gewonnen = 0, Verloren = 0, Gelijkspel = 0,Punten = 0  };
            Model.Ploeg RoyalCharleroiSportingClub = new Model.Ploeg() { PloegNaam = "Royal Charleroi Sporting Club", Gemeente = "Charleroi", Website = "https://www.sporting-charleroi.be/", Stamnummer = 22,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0 };
            Model.Ploeg KASEupen = new Model.Ploeg(){PloegNaam = "KAS Eupen",Gemeente = "Eupen", Website = "https://www.as-eupen.be/", Stamnummer = 4276,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Model.Ploeg KRCGenk = new Model.Ploeg() {PloegNaam = "KRC Genk",Gemeente = "Genk", Website = "https://www.krcgenk.be/nl", Stamnummer = 322,Gewonnen = 0, Verloren = 0,Gelijkspel = 0,Punten = 0};
            Model.Ploeg KAAGent = new Model.Ploeg(){ PloegNaam = "KAA Gent",Gemeente = "Gent", Website = "https://www.kaagent.be/nl", Stamnummer = 7,Gewonnen = 0,Verloren = 0, Gelijkspel = 0,Punten = 0};
            Model.Ploeg KVKortrijk = new Model.Ploeg {PloegNaam = "KV Kortrijk",Gemeente = "Kortrijk", Website = "https://kvk.be/", Stamnummer = 19,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Model.Ploeg KVMechelen = new Model.Ploeg {PloegNaam = "KV Mechelen",Gemeente = "Mechelen", Website = "https://www.kvmechelen.be/", Stamnummer = 25,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Model.Ploeg RoyalExcelMoeskroen = new Model.Ploeg(){PloegNaam = "Royal Excel Moeskroen",Gemeente = "Moeskroen", Website = "https://www.excel-foot.be/", Stamnummer = 216,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Model.Ploeg KVOostende = new Model.Ploeg(){PloegNaam = "KV Oostende",Gemeente = "Oostende", Website = "https://www.kvo.be/", Stamnummer = 31,Gewonnen = 0,Verloren = 0,Gelijkspel = 0,Punten = 0};
            Model.Ploeg SintTruidenseVV = new Model.Ploeg() { PloegNaam = "Sint-Truidense VV", Gemeente = "Sint-Truiden", Website = "https://www.stvv.com/nl", Stamnummer = 373, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Model.Ploeg StandardLuik = new Model.Ploeg() { PloegNaam = "Standard Luik", Gemeente = "Luik", Website = "https://standard.be/nl", Stamnummer = 16, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Model.Ploeg KVRSWaaslandSKBeveren = new Model.Ploeg() { PloegNaam = "KVRS Waasland - SK Beveren", Website = "https://www.waasland-beveren.be/", Gemeente = "Beveren", Stamnummer = 4068, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };
            Model.Ploeg SVZulteWaregem = new Model.Ploeg() { PloegNaam = "SV Zulte Waregem", Gemeente = "Waregem", Website = "https://www.essevee.be/nl", Stamnummer = 5381, Gewonnen = 0, Verloren = 0, Gelijkspel = 0, Punten = 0 };


            Model.Speler SinanBolat = new Model.Speler() {  Voornaam = "Sinan", Achternaam = "Bolat", Woonplaats = "Merksem", Email = "SinanBolat@gmail.com", Positie = "keeper", Rugnummer = 1, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            Model.Speler DieumerciMbokani  = new Model.Speler() {  Voornaam = "Dieumerci", Achternaam = "Mbokani", Woonplaats = "Merksem", Email = "DieumerciMbokani@gmail.com", Positie = "Aanvaller", Rugnummer = 70, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            Model.Speler HansVanaken = new Model.Speler() {  Voornaam = "Hans", Achternaam = "Vanaken", Woonplaats = "Brugge", Email = "HansVanaken@gmail.com", Positie = "Middenvelder", Rugnummer = 20, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };
            Model.Speler AleksandarVukotic = new Model.Speler() {  Voornaam = "Aleksandar", Achternaam = "Vukotic", Woonplaats = "Antwerpen", Email = "AleksandarVukotic@gmail.com", Positie = "Verdediger", Rugnummer = 26, GeleKaarten = 0, RodeKaarten = 0, AantalGoalen = 0, AantalAssisten = 0 };


            Model.Beker BekersVanRSCAnderlecht = new Model.Beker() { KampioenVanBelgië = 34, BekerVanBelgië = 9, SupercupVanBelgië = 13, ChampionsLeagueBeker = 0, EuropaLeagueBeker = 5 };
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

            if (!context.Bekers.Any())
            {
                context.Bekers.Add(BekersVanRSCAnderlecht);
                context.SaveChanges();
            }
        }
    }
}
