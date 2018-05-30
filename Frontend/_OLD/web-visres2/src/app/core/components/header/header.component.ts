import { Component, OnInit } from '@angular/core';

import { AuthService } from './../../services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  title = 'VisRes';

  auth$;

  constructor(private auth: AuthService) {
    this.auth$ = auth;
   }

  ngOnInit() {

  }

  test($event) {
    console.log('received: ' + $event);
  }

}
