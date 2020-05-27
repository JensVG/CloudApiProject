import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ProjectService {

  constructor(private http: HttpClient) { }
 //Get all Spelers
  GetAllSpelers() {
    return this.http.get<Speler>(`https://localhost:44377/api/v1/Spelers`)
  }

  //Get all Ploegen
  GetAllPloegen() {
    return this.http.get<Ploeg>(`https://localhost:44377/api/v1/Ploegen`)
  }

  //Get 1 Speler
  GetSpelerById(id) {
    return this.http.get<Speler>(`https://localhost:44377/api/v1/Spelers/${id}`)
  }

  //Get 1 Ploeg
  GetPloegById(id){
    return this.http.get<Ploeg>(`https://localhost:44377/api/v1/Ploegen/${id}`)
  }

  //ThirdParty
  GetThirdPartyAPI() {
    return this.http.get<Voetbal>(`https://www.scorebat.com/video-api/v1/`)
  }

  //Delete Speler
  DeleteSpelerById(id) {
    return this.http.delete<Speler>(`https://localhost:44377/api/v1/Spelers/${id}`)
  }

  //Delete Ploeg
  DeletePloegById(id) {
    return this.http.delete<Ploeg>(`https://localhost:44377/api/v1/Ploeg/${id}`)
  }

  //Search
  SearchOnSpelersVoornaam(voornaam) {
    return this.http.get<Speler>(`https://localhost:44377/api/v1/Spelers?search=${voornaam}`);
  }

  //Sort
  SortSpelers(sorttype, dir) {
    return this.http.get<Speler>(`http://localhost:44377/api/v1/Spelers?sort=${sorttype}&dir=${dir}`)
  }

  //Page 
  GetSpelersPage(page: number, length: number = 100) {
    return this.http.get<Speler>(`http://localhost:44377/api/v1/Spelers?page=${page}&length=${length}`);
  }

  //Create Speler
  CreateSpeler(Speler: any) {
    return this.http.post<Speler>(`https://localhost:44377/api/v1/Spelers`,Speler, {
      headers: new HttpHeaders({
        "Content-Type": "application/json",
      }),
    });
  }

    //Create Ploeg
  CreatePloeg(Ploeg: any) {
    return this.http.post<any>(`https://localhost:44377/api/v1/Ploeg`,Ploeg, {
      headers: new HttpHeaders({
        "Content-Type": "application/json",
      }),
    })
  }

  //Update
  UpdateSpeler(id, voornaam, achternaam, woonplaats, email, positie, rugnummer, geleKaarten, rodeKaarten, aantalGoalen, aantalAssisten): Observable<Speler> {
    var putJson = {
      id: id,
      voornaam: voornaam,
      achternaam: achternaam,
      woonplaats: woonplaats,
      email: email,
      positie: positie,
      rugnummer: rugnummer,
      geleKaarten: geleKaarten,
      rodeKaarten: rodeKaarten,
      aantalGoalen: aantalGoalen,
      aantalAssisten: aantalAssisten
    }
    return this.http.put<Speler>(`https://localhost:44377/api/v1/Spelers/${id}`, putJson, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
    }
    );
  }
}

export interface Speler {
  id: any;
  voornaam: string;
  achternaam: string;
  woonplaats: string;
  email: string;
  positie: any;
  rugnummer: any;
  geleKaarten: any;
  rodeKaarten: any;
  aantalGoalen: any;
  aantalAssisten: any;
}

/*
export interface SpelerPloeg {
  id: any;
  voornaam: string;
  achternaam: string;
  woonplaats: string;
  email: string;
  positie: any;
  rugnummer: any;
  geleKaarten: any;
  rodeKaarten: any;
  aantalGoalen: any;
  aantalAssisten: any;
  Ploeg: Ploeg[];
}
*/

export interface Ploeg {
  id: any;
  ploegNaam: string;
  gemeente: string;
  website: string;
  stamnummer: any;
  gewonnen: any;
  verloren: any;
  gelijkspel: any;
  punten: any;
}

export interface Side1 {
  name: string;
  url: string;
}

export interface Side2 {
  name: string;
  url: string;
}

export interface Competition {
  name: string;
  id: number;
  url: string;
}

export interface Video {
  title: string;
  embed: string;
}

export interface Voetbal {
  title: string;
  embed: string;
  url: string;
  thumbnail: string;
  date: Date;
  side1: Side1;
  side2: Side2;
  competition: Competition;
  videos: Video[];
}