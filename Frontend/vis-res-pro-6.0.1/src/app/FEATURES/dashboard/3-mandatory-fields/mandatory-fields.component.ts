// import { CardRotatingComponent } from '@vrs/typescripts/pro/cards/card-rotating.component';
// import { CardRevealComponent } from '@vrs/typescripts/pro/cards/card-reveal.component';

import { Component, OnInit } from '@angular/core';

import { InsuranceTypeNumberExpiredViewModel } from '@vrs/models';

@Component({
  selector: 'vrs-mandatory-fields',
  templateUrl: './mandatory-fields.component.html',
  styleUrls: ['./mandatory-fields.component.scss']
})
export class MandatoryFieldsComponent implements OnInit {

  private rotatingCardClasses: any;

  MandatoryFieldsProject: InsuranceTypeNumberExpiredViewModel[];
  MandatoryFieldsCompany: InsuranceTypeNumberExpiredViewModel[];
  MandatoryFieldIndividual: InsuranceTypeNumberExpiredViewModel[];

  constructor() {
    this.rotatingCardClasses = {'card-container': true, 'manual-flip': true, 'hover': false};
  }

  ngOnInit() {
    this.mockData();
  }

  // this is the function which changed the class name.
  rotateCard() {
    if (this.rotatingCardClasses.hover === false) {
      this.rotatingCardClasses.hover = true;
    } else {
      this.rotatingCardClasses.hover = false;
    }
  }

  mockData() {
      // 1 - Mandatory Fields / Project
      this.MandatoryFieldsProject = [
        new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Project - JDE', 11),
      ];

      // 2 - Mandatory Fields / Company
      this.MandatoryFieldsCompany = [
        new InsuranceTypeNumberExpiredViewModel('No. of new JDE Company records', 11),
        new InsuranceTypeNumberExpiredViewModel('No. of updated JDE Company records', 15)
      ];

      // 3 - Mandatory Fields / Individual
      this.MandatoryFieldIndividual = [
        new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Individual - JDE', 3),
      ];
  }

}
