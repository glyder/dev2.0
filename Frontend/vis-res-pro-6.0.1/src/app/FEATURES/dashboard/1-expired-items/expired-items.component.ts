import { Component, OnInit,
         Input } from '@angular/core';

// import { Output, EventEmitter } from '@angular/core';

import { BooksService,
         DashboardService, ObservableDashboardService
       } from '@vrs/core/services';

import { CompanyExpiredInsurancesViewModel, InsuranceTypeNumberExpiredViewModel } from '@vrs/models';

@Component({
  selector: 'vrs-expired-items',
  templateUrl: './expired-items.component.html',
  styleUrls: ['./expired-items.component.scss']
})
export class ExpiredItemsComponent implements OnInit {

  // TODO: get the import statement for @input()
  @Input() public paramLob = -999;
  @Input() public paramProj = -999;
  @Input() public paramComp = -999;
  @Input() public paramInd = -999;

  // ====================================================

  CompanyRecordsExpiredInsurances$: any = [];
  CompanyRecordsInsuranceDues$: any = [];
  IndividualRecords$: any = [];
  ContractRecords$: any = [];

  CompanyRecordsExpiredInsurances: CompanyExpiredInsurancesViewModel[];
  CompanyRecordsInsuranceDues: InsuranceTypeNumberExpiredViewModel[];
  IndividualRecords: InsuranceTypeNumberExpiredViewModel[];
  ContractRecords: InsuranceTypeNumberExpiredViewModel[];

  // ====================================================

  books$: any = [];
  complete = false;

  // ====================================================

  selectedLobID = 0;
  selectedProjectID = 0;
  selectedCompanyID = 0;
  selectedIndividualID = 0;

  // ====================================================

  constructor(public _bookService: BooksService,
              public _dashboardService: DashboardService,
              private _observableDashboardService: ObservableDashboardService) {

    // ====================================================
    // TODO: remove?
    this._bookService.index()
                     .subscribe(res => this.books$ = res);
    // ====================================================

    // EVENTS -> 12, 13, 14, 15
    // #region ""
    this._observableDashboardService.lobID
                                    .subscribe((lobID: number) => {

      console.log('Event 12 - subscribe expired-items (lobID): ' + lobID);
      this.selectedLobID = lobID;
      this.updateGrids();
    });

    this._observableDashboardService.projectID
                                    .subscribe((projectID: number) => {

      console.log('Event 13 - subscribe expired-items (projectID): ' + projectID);
      this.selectedProjectID = projectID;
      this.updateGrids();
    });

    this._observableDashboardService.companyID
                                    .subscribe((companyID: number) => {

      console.log('Event 14 - subscribe expired-items (companyID): ' + companyID);
      this.selectedCompanyID = companyID;
      this.updateGrids();
    });

    this._observableDashboardService.individualID
                                    .subscribe((individualID: number) => {

      console.log('Event 15 - subscribe expired-items (individual): ' + individualID);
      this.selectedIndividualID = individualID;
      this.updateGrids();
    });

    // ====================================================

    this.updateGrids();

    // ====================================================
    this.complete = true;
    // ====================================================
  }

  updateGrids() {

    this._dashboardService.CompanyRecordsExpiredInsurances(this.selectedLobID,
                                                           this.selectedProjectID,
                                                           this.selectedCompanyID,
                                                         //  this.selectedIndividualID
                                                          )
                          .subscribe(res => this.CompanyRecordsExpiredInsurances$ = res);

    this._dashboardService.CompanyRecordsInsuranceDue(this.selectedLobID,
                                                      this.selectedProjectID,
                                                      this.selectedCompanyID,
                                                      // this.selectedIndividualID
                                                    )
                          .subscribe(res => this.CompanyRecordsInsuranceDues$ = res);

    this._dashboardService.IndividualRecords(this.selectedLobID,
                                             this.selectedProjectID,
                                             this.selectedCompanyID,
                                            // this.selectedIndividualID
                                            )
                          .subscribe(res => this.IndividualRecords$ = res);

    this._dashboardService.ContractRecords(this.selectedLobID,
                                           this.selectedProjectID,
                                           this.selectedCompanyID,
                                          // this.selectedIndividualID
                                          )
                          .subscribe(res => this.ContractRecords$ = res);
  }



  ngOnInit() {

    // this.route.parent.data.subscribe(
    //   (data: {profile: Profile}) => {
    //     this.profile = data.profile;
    //     this.articlesConfig = {
    //       type: 'all',
    //       filters: {}
    //     }; // Only method I found to refresh article load on swap
    //     this.articlesConfig.filters.author = this.profile.username;
    //   }
    // );

    // this.mockData();
  }

  // #region "MockData()"

  mockData() {

    // 1. Company Records / Expired Insurances
    this.CompanyRecordsExpiredInsurances = [
      new CompanyExpiredInsurancesViewModel('All Insurances', 2954),
      new CompanyExpiredInsurancesViewModel('Workcover (or equivalent)', 355),
      new CompanyExpiredInsurancesViewModel('Public Liability', 111),
      new CompanyExpiredInsurancesViewModel('Professional Indemnity', 537),
      new CompanyExpiredInsurancesViewModel('Works Insurance', 473),
      new CompanyExpiredInsurancesViewModel('Motor Vehicle Insurance', 337),
      new CompanyExpiredInsurancesViewModel('Plant Insurance', 141),
      new CompanyExpiredInsurancesViewModel('No. of Accreditation and Licences', 67),
    ];

    // 2. Company Records / Insurance due within 30 days
    this.CompanyRecordsInsuranceDues = [
      new InsuranceTypeNumberExpiredViewModel('All Insurances', 412),
      new InsuranceTypeNumberExpiredViewModel('Workcover (or equivalent)', 74),
      new InsuranceTypeNumberExpiredViewModel('Public Liability', 162),
      new InsuranceTypeNumberExpiredViewModel('Professional Indemnity', 26),
      new InsuranceTypeNumberExpiredViewModel('Works Insurance', 4),
      new InsuranceTypeNumberExpiredViewModel('Motor Vehicle Insurance', 109),
      new InsuranceTypeNumberExpiredViewModel('Plant Insurance', 37),
    ];

    // 3. Individual Records
    this.IndividualRecords = [
      new InsuranceTypeNumberExpiredViewModel('All Insurances', 69),
      new InsuranceTypeNumberExpiredViewModel('Workcover (or equivalent):', 17),
      new InsuranceTypeNumberExpiredViewModel('Public Liability', 20),
      new InsuranceTypeNumberExpiredViewModel('Professional Indemnity', 2),
      new InsuranceTypeNumberExpiredViewModel('Works Insurance', 3),
      new InsuranceTypeNumberExpiredViewModel('Motor Vehicle Insurance', 21),
    ];

    // 4. Contract Records
    this.ContractRecords = [
      new InsuranceTypeNumberExpiredViewModel('All Insurances', 11),
      new InsuranceTypeNumberExpiredViewModel('Workcover (or equivalent):', 13),
      new InsuranceTypeNumberExpiredViewModel('Public Liability', 22),
      new InsuranceTypeNumberExpiredViewModel('Professional Indemnity', 6),
      new InsuranceTypeNumberExpiredViewModel('Works Insurance', 3),
      new InsuranceTypeNumberExpiredViewModel('Motor Vehicle Insurance', 2),
    ];
  }

  // #endregion

}
