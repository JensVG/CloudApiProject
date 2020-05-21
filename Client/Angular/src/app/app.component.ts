import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { OAuthService, JwksValidationHandler } from 'angular-oauth2-oidc';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  constructor(private router: Router,private oauthService: OAuthService) {  
    this.configureSingleSignOn();
  }
  img : string = "../../../assets/images/jupiler.png"

 configureSingleSignOn(){
this.oauthService.tokenValidationHandler = new JwksValidationHandler();
this.oauthService.loadDiscoveryDocumentAndTryLogin();
 }
  login(){
this.oauthService.initImplicitFlow();
  }

  logout(){
    this.oauthService.logOut();
  }
get token(){
  let claims:any = this.oauthService.getIdentityClaims();
  return claims ? claims: null;
}
  
  get IsHome() {
    return this.router.isActive('/start', true)
  }

  get Style() {
    switch (this.router.url) {
      case '/spelers':
      case '/ploegen':
        return "ui-button-danger"
      default:
        return "Todo"
    }
  }
}