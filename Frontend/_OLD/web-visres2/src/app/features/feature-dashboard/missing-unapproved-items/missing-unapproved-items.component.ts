import { CardRotatingComponent } from '@vrs/typescripts/pro/cards/card-rotating.component';
import { CardRevealComponent } from '@vrs/typescripts/pro/cards/card-reveal.component';

import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-missing-unapproved-items',
  templateUrl: './missing-unapproved-items.component.html',
  styleUrls: ['./missing-unapproved-items.component.scss']
})
export class MissingUnapprovedItemsComponent implements OnInit {

  private rotatingCardClasses: any;

  constructor() {
    this.rotatingCardClasses = {'card-container': true, 'manual-flip': true, 'hover': false};
  }

  ngOnInit() {


  }

  // this is the function which changed the class name.
  rotateCard() {
    if (this.rotatingCardClasses.hover === false) {
      this.rotatingCardClasses.hover = true;
    } else {
      this.rotatingCardClasses.hover = false;
    }
  }

}
