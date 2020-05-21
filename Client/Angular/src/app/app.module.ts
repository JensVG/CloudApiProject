//Modules
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { OAuthModule } from 'angular-oauth2-oidc';

//PrimeNG
import { PanelModule } from 'primeng/panel';
import { ButtonModule } from 'primeng/button';
import { ToolbarModule } from 'primeng/toolbar'

//Componenten
import { AppComponent } from './app.component';
import { StartPaginaComponent } from './startpagina/startpagina.component';
import { SpelerComponent } from './speler/speler.component';
import { PloegComponent } from './ploeg/ploeg.component';

@NgModule({
  declarations: [
    AppComponent,
    StartPaginaComponent,
    SpelerComponent,
    PloegComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    OAuthModule.forRoot(),
    RouterModule.forRoot([
      {
        path: 'start',
        component: StartPaginaComponent
      },
      {
        path: 'spelers',
        component: SpelerComponent
      },
      {
        path: 'ploegen',
        component: PloegComponent
      },
      {
        path: "",
        pathMatch: "full",
        redirectTo: "start"
      },
      {
        path: "*",
        redirectTo: "start"
      }],
      {
        useHash: true
      }),
  PanelModule,
  ButtonModule,
  ToolbarModule
],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
