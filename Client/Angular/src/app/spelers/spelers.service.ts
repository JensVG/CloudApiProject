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
  DeleteSpelerById(id){
    return this.http.delete<Speler>(`https://localhost:44377/api/v1/Spelers/${id}`)
  }
  CreateSpeler(speler : Speler) {
    return this.http.post<Speler[]>(`https://localhost:44377/api/v1/Spelers`, speler)
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
      })
  });
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

