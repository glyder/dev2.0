import { Component, OnInit, OnDestroy } from '@angular/core';

import { Router, NavigationEnd } from '@angular/router';
import { Subscription } from 'rxjs/Subscription';

import { NgwWowService } from 'ngx-wow';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})

export class AppComponent implements OnInit, OnDestroy {

  title = 'VisRes';

  // COMMENT OUT wow in index.html and manually install to get rid of javascript.
  // https://github.com/tinesoft/ngx-wow
  // WOW - keep refs to subscription to be abble to unsubscribe later
  // (NOTE: unless you want to be notified when an item is revealed by WOW,
  //  you absolutely don't need this line and related, for the library to work
  // only the call to `this.wowService.init()` at some point is necessary
  private wowSubscription: Subscription;

  constructor(
    private router: Router,
    private wowService: NgwWowService,
  ) {

    // WOW - Reload WoW animations when done navigating to page, but you are free to call it whenever/wherever you like
    this.router.events.filter(event => event instanceof NavigationEnd).subscribe(event => {
      this.wowService.init();
    });
  }

  ngOnInit() {

    // WOW - subscribe to WOW observable to react when an element is revealed
    this.wowSubscription = this.wowService
                               .itemRevealed$
                               .subscribe( (item: HTMLElement) => {
                                  // do whatever you want with revealed element
                                });
  }

  ngOnDestroy() {
    this.wowSubscription.unsubscribe();       // WOW - unsubscribe (if necessary) to WOW observable to prevent memory leaks
  }


  // https://mdbootstrap.com/support/close-navbar-after-click/
  hideNavbar( e: any ) { e.hide(); }        // Hide sideNav - sidenav.hide();
  showNavbar( e: any ) { e.show(); }        // Show sideNav - sidenav.show();
  toggleNavbar( e: any ) { e.toggle(); }    // Toggle sideNav - sidenav.toggle();
}
