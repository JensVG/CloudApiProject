import { Component, OnInit } from '@angular/core';
import { PloegenService } from '../ploegen/ploegen.service'

@Component({
  selector: 'app-ploeg',
  templateUrl: './ploeg.component.html',
  styleUrls: ['./ploeg.component.css']
})
export class PloegComponent implements OnInit {
  IdPloeg: string = "3"
  PloegInfo: Ploeg;
  constructor(private ploeg: PloegenService) { }

  GetPloeg(IdPloeg: string) {
    this.ploeg.GetPloegById(IdPloeg).subscribe((info) => {
      this.PloegInfo = {
        id: info.id,
        ploegNaam: info.ploegNaam,
        gemeente: info.gemeente,
        website: info.website,
        stamnummer: info.stamnummer,
        gewonnen: info.gewonnen,
        verloren: info.verloren,
        gelijkspel: info.gelijkspel,
        punten: info.punten
      }
    })
  }
  ngOnInit() {
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
