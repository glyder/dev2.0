import { Injectable } from '@angular/core';


@Injectable()
export class JwtService {

  getToken(): String {
    return sessionStorage['jwtToken'];
  }

  saveToken(token: String) {
    sessionStorage['jwtToken'] = token;
  }

  destroyToken() {
    sessionStorage.removeItem('jwtToken');
  }

}
