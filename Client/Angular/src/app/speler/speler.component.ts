import { Component, OnInit } from '@angular/core';
import { ProjectService, Speler } from '../services/project.service'

@Component({
  selector: 'app-speler',
  templateUrl: './speler.component.html',
  styleUrls: ['./speler.component.css']
})
export class SpelerComponent implements OnInit {
  Idspelerget: string;
  Lengte: number;
  Page: number;
  Idspelerdelete: string;
  SpelerInfo: Speler;
  SpelersInfo: Speler;
  VoornaamSpelersInfo: Speler;
  SorteerMethode: string;
  SorteerOp: string;
  SpelerUpdate: Speler[];
  SelectedId: number;
  NewVoornaam: string;
  NewAchternaam: string;
  NewWoonplaats: string;
  NewEmail: string;
  NewPositie: string;
  NewRugnummer: number;
  NewGeleKaarten: number;
  NewRodeKaarten: number;
  NewAantalGoalen: number;
  NewAantalAssisten: number;


  constructor(private speler: ProjectService) { }

  SearchSpelerOnID(IdSpeler: string) {
    this.speler.GetSpelerById(IdSpeler).subscribe((info) => {
      this.SpelerInfo = {
        id: info.id,
        voornaam: info.voornaam,
        achternaam: info.achternaam,
        woonplaats: info.woonplaats,
        email: info.email,
        positie: info.positie,
        rugnummer: info.rugnummer,
        geleKaarten: info.geleKaarten,
        rodeKaarten: info.rodeKaarten,
        aantalGoalen: info.aantalGoalen,
        aantalAssisten: info.aantalAssisten
      };
    })
  }

  DeleteSpelerOnID(IdSpeler: string) {
    this.speler.DeleteSpelerById(IdSpeler).subscribe((info) => {
      this.SpelerInfo = {
        id: info.id,
        voornaam: info.voornaam,
        achternaam: info.achternaam,
        woonplaats: info.woonplaats,
        email: info.email,
        positie: info.positie,
        rugnummer: info.rugnummer,
        geleKaarten: info.geleKaarten,
        rodeKaarten: info.rodeKaarten,
        aantalGoalen: info.aantalGoalen,
        aantalAssisten: info.aantalAssisten,
      };
    })
  }

  GetAllSpelers() {
    return this.speler.GetAllSpelers().subscribe(spelersinfo => {
      this.SpelersInfo = spelersinfo;
    })
  }

  GetAllSpelersWithName(voornaam: Speler) {
    console.log(voornaam);
    return this.speler.SearchOnSpelersVoornaam(voornaam).subscribe(spelersinfo => {
      this.VoornaamSpelersInfo = spelersinfo;
    })
  }

  WayToSort() {
    this.speler.SortSpelers(this.SorteerOp, this.SorteerMethode).subscribe(spelersinfo => {
      this.SpelersInfo = spelersinfo;
    })
  }

  CreateSpeler(voornaam:string, achternaam:string, woonplaats:string, email:string,rugnummer:string,positie:string) {
    var input = {
      voornaam: voornaam,
      achternaam: achternaam,
      woonplaats: woonplaats,
      email: email,
      rugnummer: rugnummer,
      positie: positie
    };
    this.speler.CreateSpeler(input).subscribe();
  }


  UpdateSpeler() {
    this.speler.UpdateSpeler(this.SelectedId, this.NewVoornaam, this.NewAchternaam, this.NewWoonplaats, this.NewEmail, this.NewPositie, this.NewRugnummer, this.NewGeleKaarten, this.NewRodeKaarten, this.NewAantalGoalen, this.NewAantalAssisten).subscribe(speler => this.SpelerUpdate.push(speler));
  }

  GetPageSpelers(Page: number, Lengte: number) {
    this.speler.GetSpelersPage(Page, Lengte).subscribe(SpelersInfo => {
      this.SpelerInfo = SpelersInfo;
      console.log(Lengte);
      console.log("werkt");
    })
  }

  async ngOnInit() {
    this.GetAllSpelers();
  }

}