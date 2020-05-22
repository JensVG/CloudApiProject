import { Component, OnInit } from '@angular/core';
import { SpelersService, Voetbal } from '../spelers/spelers.service'

@Component({
  selector: 'app-ploeg',
  templateUrl: './ploeg.component.html',
  styleUrls: ['./ploeg.component.css']
})
export class PloegComponent implements OnInit {
  VideosInfo: Voetbal;
  title: string;

  constructor(private speler: SpelersService) { }

  GetAllVideos() {
    return this.speler.GetThirdPartyAPI().subscribe(videosinfo => {
      this.VideosInfo =  videosinfo;
    })
  }

  async ngOnInit() {
    this.GetAllVideos();
  }

}
