import { Component, OnInit } from '@angular/core';

// import { AngularFirestore, AngularFirestoreCollection, AngularFirestoreDocument } from 'angularfire2/firestore';
// import { Observable } from 'rxjs/Observable';
// import 'rxjs/add/operator/map';
import { BooksService, ContactsService } from './../../../core/services/test/index';

import {FormControl} from '@angular/forms';

import {MatSnackBar} from '@angular/material';


@Component({
  selector: 'app-vrs-ui',
  templateUrl: './vrs-ui.component.html',
  styleUrls: ['./vrs-ui.component.scss']
})
export class VrsUiComponent implements OnInit {

  title = 'VisRes';


  panelOpenState = true;
  // tslint:disable-next-line:member-ordering
  books$: any;

  constructor(public _bookService: BooksService,
              public snackBar: MatSnackBar) {

  }

  ngOnInit() {
    this._bookService.index().subscribe(res => this.books$ = res);

    this.complete = true;
  }

  // ===========================================================
  // VRS - UI buttons

  // tslint:disable-next-line:member-ordering
  complete: boolean;

  button_login(id: string) {
    this.complete = false;
    console.log('login clicked: ' + id);
  }

  button_test(id: string) {
    console.log('test clicked: ' + id);
  }

  // ============================================================
  // Material Design

  // tslint:disable-next-line:member-ordering
  foods = [
    {value: 'steak-0', viewValue: 'Steak'},
    {value: 'pizza-1', viewValue: 'Pizza'},
    {value: 'tacos-2', viewValue: 'Tacos'}
  ];
  // tslint:disable-next-line:member-ordering


  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000,
    });
  }

  // ============================================================



}
