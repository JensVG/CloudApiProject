import { Component, OnInit } from '@angular/core';
import { ProjectService, Speler } from '../services/project.service'

@Component({
  selector: 'app-speler',
  templateUrl: './speler.component.html',
  styleUrls: ['./speler.component.css']
})
export class SpelerComponent implements OnInit {
  Idspelerget: string;
  page: number = 1;
  maxPage: number = 3;
  Idspelerdelete: string;
  SpelerInfo: Speler;
  SpelersInfo: Speler;
  VoornaamSpelersInfo: Speler;
  SorteerMethode: string;
  SorteerOp: string;
  SpelerUpdate: Speler;
  SelectedId: number;
  //Create
  VoornaamNewSpeler: string;
  AchternaamNewSpeler: string;
  WoonplaatsNewSpeler: string;
  EmailNewSpeler: string;
  RugnummerNewSpeler: number;
  PositieNewSpeler: string;
  //Update
  IDUpdateSpeler: string;
  VoornaamUpdateSpeler: string;
  AchternaamUpdateSpeler: string;
  WoonplaatsUpdateSpeler: string;
  EmailUpdateSpeler: string;
  RugnummerUpdateSpeler: number;
  PositieUpdateSpeler: string;
  GeleKaartenUpdateSpeler: number;
  RodeKaartenUpdateSpeler: number;
  AantalAssistenUpdateSpeler: number;
  AantalGoalenUpdateSpeler: number;

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

  CreateSpeler() {
    var input = {
      voornaam: this.VoornaamNewSpeler,
      achternaam: this.AchternaamNewSpeler,
      woonplaats: this.WoonplaatsNewSpeler,
      email: this.EmailNewSpeler,
      rugnummer: this.RugnummerNewSpeler,
      positie: this.PositieNewSpeler
    };
    this.speler.CreateSpeler(input).subscribe();
  }


  UpdateSpeler() {
    var input = {
      id: this.IDUpdateSpeler,
      voornaam: this.VoornaamUpdateSpeler,
      achternaam: this.AchternaamUpdateSpeler,
      woonplaats: this.WoonplaatsUpdateSpeler,
      email: this.EmailUpdateSpeler,
      rugnummer: this.RugnummerUpdateSpeler,
      positie: this.PositieUpdateSpeler,
      geleKaarten: this.GeleKaartenUpdateSpeler,
      rodeKaarten: this.RodeKaartenUpdateSpeler,
      aantalGoalen: this.AantalGoalenUpdateSpeler,
      aantalAssisten: this.AantalAssistenUpdateSpeler 

    }
    this.speler.UpdateSpeler(input).subscribe();
  }

  GetPageSpelers() {
    this.speler.GetSpelersPage(this.page).subscribe(SpelersInfo => {
      this.SpelersInfo = SpelersInfo;
    })
  }

  VolgendePagina(){
    this.page++;
    this.GetPageSpelers();
  }

  VorigePagina(){
    this.page--;
    this.GetPageSpelers();
  }

  async ngOnInit() {
    this.GetAllSpelers();
  }

}