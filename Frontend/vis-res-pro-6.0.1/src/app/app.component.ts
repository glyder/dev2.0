import { Component, OnInit, OnDestroy, AfterViewInit } from '@angular/core';
import { environment } from '@vrs/../environments/environment';

// import { correctHeight, detectBody } from '@vrs/shared/jQuery/app.helpers';

// import { ToastService } from './typescripts/pro/alerts';

// MetaData & Template
@Component({
  selector: 'vrs-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})

// Class - ES Class
export class AppComponent
       implements OnInit, OnDestroy, AfterViewInit {

  graphic: string = environment.person;
  time = new Date();

  // ================

  constructor() {
    setInterval( () => this.time = new Date(), 1000);
  }

  ngAfterViewInit() {
    // Jquery is "possible" but we don't want it as we want Angular to pick up the DOM events.
    // Run correctHeight function on load and resize window event
    // $(window).bind('load resize', function() {
    //     correctHeight();
    //     detectBody();
    // });
  }

  ngOnInit() {  }
  ngOnDestroy() {  }

  // =====================================================
  // VRS - UI buttons

  // tslint:disable-next-line:member-ordering
  complete: boolean;

  button_login(id: string) {
    this.complete = false;
    // tslint:disable-next-line:no-console
    console.log('login clicked: ' + id);
  }

  button_test(id: string) {
    // tslint:disable-next-line:no-console
    console.log('test clicked: ' + id);
  }



}
