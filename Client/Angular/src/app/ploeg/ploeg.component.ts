import { Component, OnInit } from '@angular/core';
import { ProjectService, Voetbal, Ploeg } from '../services/project.service'

@Component({
  selector: 'app-ploeg',
  templateUrl: './ploeg.component.html',
  styleUrls: ['./ploeg.component.css']
})
export class PloegComponent implements OnInit {
  VideosInfo: Voetbal;
  title: string;
  PloegenInfo: Ploeg;
  PloegInfo: Ploeg;
  Idploegget: string;
  Idploegdelete: string;

  constructor(private ploeg: ProjectService) { }

  GetAllVideos() {
    return this.ploeg.GetThirdPartyAPI().subscribe(videosinfo => {
      this.VideosInfo = videosinfo;
    })
  }

  GetAllPloegen() {
    return this.ploeg.GetAllPloegen().subscribe(ploegeninfo => {
      this.PloegenInfo = ploegeninfo;
    })
  }

  SearchPloegOnID(IdPloeg: string) {
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
      };
    })
  }

  DeletePloegOnID(IdPloeg: string) {
    this.ploeg.DeletePloegById(IdPloeg).subscribe((info) => {
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
      };
    })
  }

  async ngOnInit() {
    this.GetAllPloegen();
    this.GetAllVideos();
  }

}
