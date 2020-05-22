import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class SpelersService {

  constructor(private http: HttpClient) { }

  GetAllSpelers() {
    return this.http.get<Speler>(`https://localhost:44377/api/v1/Spelers`)
  }

  GetSpelerById(id){
    return this.http.get<Speler>(`https://localhost:44377/api/v1/Spelers/${id}`)
  }

  GetThirdPartyAPI(){
    return this.http.get<Voetbal>(`https://www.scorebat.com/video-api/v1/`)
  }

  DeleteSpelerById(id){
    return this.http.delete<Speler>(`https://localhost:44377/api/v1/Spelers/${id}`)
  }

  CreateSpeler(speler) {
    return this.http.post<Speler>(`https://localhost:44377/api/v1/Spelers`, speler, {
      headers:new HttpHeaders({
        "Content-Type": "application/json",
      }),
    });
  }

  UpdateSpeler(id, voornaam,achternaam,woonplaats,email,positie,rugnummer,geleKaarten,rodeKaarten,aantalGoalen,aantalAssisten): Observable<Speler>{
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
      headers:new HttpHeaders({
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
*/

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