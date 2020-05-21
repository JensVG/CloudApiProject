import { Component, OnInit } from '@angular/core';
import { SpelersService } from '../spelers/spelers.service'

@Component({
  selector: 'app-speler',
  templateUrl: './speler.component.html',
  styleUrls: ['./speler.component.css']
})
export class SpelerComponent implements OnInit {
  Idspelerget: string;
  Idspelerdelete: string;
  SpelerInfo: Speler;
  SpelersInfo: Speler;
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


  constructor(private speler: SpelersService) { }

  SearchSpelerOnID(IdSpeler: string) {
    this.speler.GetSpelerById(IdSpeler).subscribe((info) => {
      this.SpelerInfo = {
        id: info.id,
        voornaam: info.voornaam,
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

  DeleteSpelerOnID(IdSpeler: string) {
    this.speler.DeleteSpelerById(IdSpeler).subscribe((info) => {
      this.SpelerInfo = {
        id: info.id,
        voornaam: info.voornaam,
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

  GetAllSpelers(){
    return this.speler.GetAllSpelers().subscribe(spelersinfo => {
      this.SpelersInfo = spelersinfo;
    })
  }

  UpdateSpeler() {
    this.speler.UpdateSpeler(this.SelectedId, this.NewVoornaam,this.NewAchternaam,this.NewWoonplaats,this.NewEmail,this.NewPositie,this.NewRugnummer,this.NewGeleKaarten,this.NewRodeKaarten,this.NewAantalGoalen,this.NewAantalAssisten).subscribe(speler => this.SpelerUpdate.push(speler));
  }

  async ngOnInit() {
         this.GetAllSpelers();
    }

}

export interface Speler {
  id: any;
  voornaam: string;
  woonplaats: string;
  email: string;
  positie: any;
  rugnummer: any;
  geleKaarten: any;
  rodeKaarten: any;
  aantalGoalen: any;
  aantalAssisten: any;
}
