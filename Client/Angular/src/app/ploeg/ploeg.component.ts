import { Component, OnInit } from '@angular/core';
import { ProjectService, Voetbal } from '../services/project.service'

@Component({
  selector: 'app-ploeg',
  templateUrl: './ploeg.component.html',
  styleUrls: ['./ploeg.component.css']
})
export class PloegComponent implements OnInit {
  VideosInfo: Voetbal;
  title: string;

  constructor(private speler: ProjectService) { }

  GetAllVideos() {
    return this.speler.GetThirdPartyAPI().subscribe(videosinfo => {
      this.VideosInfo =  videosinfo;
    })
  }

  async ngOnInit() {
    this.GetAllVideos();
  }

}
