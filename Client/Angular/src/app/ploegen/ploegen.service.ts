import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class PloegenService {

  constructor(private http: HttpClient) { }

  GetAllPloegen() {
    return this.http.get<Ploeg>(`https://localhost:44377/api/v1/Ploegen`)
  }
  GetPloegById(IdPloeg){
    return this.http.get<Ploeg>(`https://localhost:44377/api/v1/Ploegen/${IdPloeg}`)
  }

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