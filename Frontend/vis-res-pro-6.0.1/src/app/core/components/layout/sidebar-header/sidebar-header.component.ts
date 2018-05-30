import { Component, OnInit } from '@angular/core';

import { environment } from '@vrs/../environments/environment';

@Component({
  selector: 'vrs-core-layout-sidebar-header',
  templateUrl: './sidebar-header.component.html',
  styleUrls: ['./sidebar-header.component.scss']
})
export class SidebarHeaderComponent implements OnInit {

  graphic: string = environment.person;

  constructor() { }

  ngOnInit() {
  }

  // https://mdbootstrap.com/support/close-navbar-after-click/
  hideNavbar( e: any ) { e.hide(); }        // Hide sideNav - sidenav.hide();
  showNavbar( e: any ) { e.show(); }        // Show sideNav - sidenav.show();
  toggleNavbar( e: any ) { e.toggle(); }    // Toggle sideNav - sidenav.toggle();
}
