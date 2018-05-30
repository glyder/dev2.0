import { Injectable } from '@angular/core';
import { Router } from '@angular/router';



// https://dzone.com/articles/implementing-guard-in-angular-5-app

@Injectable()
export class AuthService {

  constructor(private myRoute: Router) { }

  sendToken(token: string) {
    sessionStorage.setItem('LoggedInUser', token);
  }

  getToken() {
    return sessionStorage.getItem('LoggedInUser');
  }

  isLoggednIn() {
    return this.getToken() !== null;
  }

  logout() {
    sessionStorage.removeItem('LoggedInUser');
    this.myRoute.navigate(['login']);
  }

}
