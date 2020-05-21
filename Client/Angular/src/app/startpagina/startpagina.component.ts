import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-startpagina',
  templateUrl: './startpagina.component.html',
  styleUrls: ['./startpagina.component.css']
})
export class StartPaginaComponent implements OnInit {
  background : string = "../../../assets/images/jupiler.png"
  constructor() { }

  ngOnInit() {
  }

}