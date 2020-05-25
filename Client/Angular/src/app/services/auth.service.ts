import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/auth';
import * as firebase from 'firebase/app';

@Injectable({
    providedIn: 'root'
})

export class AuthService {
    constructor(public afAuth: AngularFireAuth) { }
    doGoogleLogin() {
        return new Promise<any>((resolve, reject) => {
            let provider = new firebase.auth.GoogleAuthProvider();
            provider.addScope('profile');
            provider.addScope('email');
            this.afAuth
                .signInWithPopup(provider)
                .then(res => {
                    resolve(res);
                })
        })
    }
}