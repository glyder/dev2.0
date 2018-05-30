import { Component, OnInit } from '@angular/core';

import { InsuranceTypeNumberExpiredViewModel } from '@vrs/models';

@Component({
  selector: 'vrs-unapproved-items',
  templateUrl: './unapproved-items.component.html',
  styleUrls: ['./unapproved-items.component.scss']
})
export class UnapprovedItemsComponent implements OnInit {

  UnapprovedItemsProjects: InsuranceTypeNumberExpiredViewModel[];
  UnapprovedItemsCompanies: InsuranceTypeNumberExpiredViewModel[];
  UnapprovedItemsIndividuals: InsuranceTypeNumberExpiredViewModel[];
  UnapprovedItemsContracts: InsuranceTypeNumberExpiredViewModel[];

  constructor() { }

  ngOnInit() {
    this.mockData();
  }

  mockData() {

    // 1. Unapproved Items / Projects
    this.UnapprovedItemsProjects = [
      new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Projects VisRes', 49),
    ];

    // 2. Unapproved Items / Companies
    this.UnapprovedItemsCompanies = [
      new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Companies VisRes', 692),
      new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Commpanies SSP', 5),
    ];

    // 3. Unapproved Items / Individual
    this.UnapprovedItemsIndividuals = [
      new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Individuals VisRes', 19210),
      new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Individuals SSP', 53),
    ];

    // 4. Unapproved Items / Contracts
    this.UnapprovedItemsContracts = [
      new InsuranceTypeNumberExpiredViewModel('No. of Unapproved Contracts VisRes', 69),
    ];


  }


}
