
import { Component, ViewChild, OnInit, HostBinding } from '@angular/core'; // , Input

// #region "RxJS"
  import { Observable } from 'rxjs/Observable';
  import 'rxjs/add/observable/empty';
//  import {EmptyObservable} from 'rxjs/observable/EmptyObservable';
  // import { map } from 'rxjs/operators/map';
  // import { ListBoxModel } from '@vrs/models';       // LOBs
//#endregion

// #region "Services/Models"
import { ObservableDashboardService,
         LOBsService, CompaniesService,
         ProjectsService, IndividualsService } from '@vrs/core/services';

import { DropDownList } from '@vrs/models/DropDownList';
// #endregion

@Component({
  selector: 'vrs-home-dashboard',
  templateUrl: './home-dashboard.component.html',
  styleUrls: ['./home-dashboard.component.scss']
})
export class HomeDashboardComponent implements OnInit {

  @ViewChild('ddlLob') public ddlLob: any;
  @ViewChild('ddlProject') public ddlProject: any;
  @ViewChild('ddlCompany') public ddlCompany: any;
  @ViewChild('ddlIndividual') public ddlIndividual: any;

// #region "links"
  // communicate between NG components
  // https://medium.com/dailyjs/3-ways-to-communicate-between-angular-components-a1e3f3304ecb
  // https://medium.com/@mirokoczka/thanks-for-your-response-187f56eb07b5
  // https://angularfirebase.com/lessons/sharing-data-between-angular-components-four-methods/#parent-component-ts

  // https://www.c-sharpcorner.com/article/learn-about-angular-lifecycle-hooks/
  // ==========================
  // dateOptionsSelect= [ { value: 0, label: 'Select All', selected: true }, { value: 1, label: 'Today' }, { value: 2, label: 'Yesterday' },
  // ];

  // https://stackoverflow.com/questions/47568626/how-do-i-create-a-callback-on-material-angular-select
  // https://www.concretepage.com/angular-2/angular-2-select-option-multiple-select-option-validation-example-using-template-driven-form

  //#endregion

  // ===========================================
  // #region "Kendo UI"
  // https://www.telerik.com/kendo-angular-ui/components/dropdowns/dropdownlist/data-binding/

  public nukeList: Array<DropDownList> = [];

  public viewLob$: Observable<any>;
  public placeHolderLob: DropDownList = { text: 'Select All - Lobs...', value: null };
  public selectedLobID? = 0;
  public valueLobID?: number;

  public viewProject$: Observable<any>;
  public placeHolderProject: DropDownList = { text: 'Select All - Projects...', value: null };
  public selectedProjectID? = 0;
  public valueProjectID?: number;

  public viewCompany$: Observable<any>;
  public placeHolderCompany: DropDownList = { text: 'Select All - Companies...', value: null };
  public selectedCompanyID? = 0;
  public valueCompanyID?: number;

  public viewIndividual$: Observable<any>;
  public placeHolderIndividual: DropDownList = { text: 'Select All - Individuals...', value: null };
  public selectedIndividualID? = 0;
  public valueIndividualID?: number;

// #endregion

// #region "Selected items"
    @HostBinding('class.is-open')
    isOpen = true;
// #endregion

  // ===========================================
  // Temp
  // observable = Observable.create( (observer: any) => {
  //   observer.next( 'hello' );
  //   observer.next( 'world' );
  //   observer.next( 'okay stop now' );
  // });

  constructor(private _observableDashboardService: ObservableDashboardService,

              private _lobsService: LOBsService,
              private _companiesService: CompaniesService,
              private _projectsService: ProjectsService,
              private _individualsService: IndividualsService
            ) {
  }

  ngOnInit() {
    // this.ddlLob.toggle(true);    // Open Lob on open

    // EVENTS -> 2, 3, 4, 5 (get lob, proj, comp, ind)
    this.subscribeToService();

    // Events -> 6
    this.loadListboxes();

    // ======================================
    // this.observable.subscribe((val: any) => console.log(val));
    // this.observable.subscribe((x: any) => this.addItem(x));

    // ======================================
    // #region "Toggle - Open/Close"
        this._observableDashboardService.isOpen.subscribe((isOpen: boolean) => {
          this.isOpen = isOpen;
        });
    // #endregion
  }

  // addItem(val: any) {
  //   const node = document.createElement('li');
  //   const textnode = document.createTextNode(val);
  //   node.appendChild(textnode);
  //   // document.getElementById('output').appendChild(node);
  // }

  // ======================================
  // #region "onChange() Listboxes - (CHILD update --> PARENT)"
  // Events 7a, 8a, 9a, 10a - CHANGED
  public valueChangeLobID(_value: any): void {
    console.log('Event 7a - LOBID parentNEXT ==========> ' + _value);
    this._observableDashboardService.lobID.next(_value);      // Event 7a
  }

  public valueChangeProjectID(_value: any): void {
    console.log('Event 8a - ProjectID parentNEXT ==========> ' + _value);
    this._observableDashboardService.projectID.next(_value);  // Event 8a
  }

  public valueChangeCompanyID(_value: any): void {
    console.log('Event 9a - CompanyID parentNEXT ==========> ' + _value);
    this._observableDashboardService.companyID.next(_value);  // Event 9a
  }

  public valueChangeIndividualID(_value: any): void {
    console.log('Event 10a - IndividualID parentNEXT ==========> ' + _value);
    this._observableDashboardService.individualID.next(_value);  // Event 10a
  }

  //#endregion

  // ======================================
  // EVENTS -> 2, 3, 4, 5, 7b
  // #region "subscribe -> GET Parent updates"
  subscribeToService() {

    // 2 - get LOBID
    this._observableDashboardService.lobID.subscribe((lobID: number) => {
      console.log('Event 2 - [LOBID.subscribe] ----------> ' + lobID);
      this.selectedLobID = lobID;

      // console.log("subcribe to LOBID updated to: " + value);
      // if (value > 0) {
      //   console.log('Load Project list box: ' + value);
      //   this._projectsService.queryListBox(value);                           // Event 7b
      // }

    });


    // this._projectsService.unsubscribe();
    // this.viewProject$ = new Observable<any>();
    // this.viewProject$ = this._projectsService;
    // 7b
    this._observableDashboardService.lobID.subscribe((lobID: number) => {
      console.log('Event 7 - [lobID.subscribe] ------>' + lobID);
      this.selectedLobID = lobID;

      if (lobID > 0) {
        console.log(`Event 7 -[lobID.subscribe] listbox LOAD projects (lobID): ${lobID}`);
        this._projectsService.queryListBox(lobID);                           // Event 7b
      } else {
        console.log('Event 7 - [lobID.subscribe] RESET projects as lobID: ' + lobID);
        // reset project
        this.listboxProjectReset();

        // TODO: improvement, this seems like a hack. returns a empty rows
        //       but what it needs to do is just delete the current rows in project listbox.
        // this._projectsService.queryListBox(lobID);      // Event 7b
        this.viewLob$ = new Observable<any>();
      }

    });

    this._observableDashboardService.projectID.subscribe((projectID: number) => {
      console.log('Event 3 - [projectID.subscribe] ------>' + projectID);
      this.selectedProjectID = projectID;

      if (this.selectedLobID && projectID && projectID > 0) {
        console.log(`Event 8b - [projectID.subscribe] listbox LOAD companies (lobID, projID): ${this.selectedLobID} , ${projectID}`);
        this._companiesService.queryListBox(this.selectedLobID, projectID);                       // Event 8b
      }

    });

    this._observableDashboardService.companyID.subscribe((companyID: number) => {
      console.log('Event 4 - [companyID.subscribe] ------>' + companyID);
      this.selectedCompanyID = companyID;

      if (this.selectedLobID && this.selectedProjectID && companyID && companyID > 0) {
        console.log(`Event 9b -  [companyID.subscribe] listbox LOAD individuals (lobID, projID, compID): ` +
                                                                      `${this.selectedLobID},${this.selectedProjectID},${companyID}`);
        this._individualsService.queryListBox(this.selectedLobID, this.selectedProjectID, companyID);          // Event 9b
      }
    });

    this._observableDashboardService.individualID.subscribe((individualID: number) => {
      console.log('Event 5 -  [individualID.subscribe] ------>' + individualID);
      this.selectedIndividualID = individualID;

    });
  }
  // #endregion

  // ======================================
  // #region "Listbox RESET"

  listboxProjectReset() {
    // reset project
    this._observableDashboardService.projectID.next(0)
    this.ddlProject.index = 0;
    this.ddlProject.value = '';
    this.ddlProject.reset();
  }

  listboxCompanyReset() {
    // reset project
    this._observableDashboardService.companyID.next(0)
    this.ddlCompany.index = 0;
    this.ddlCompany.value = '';
    this.ddlCompany.reset();
  }

  listboxindividualReset() {
    // reset project
    this._observableDashboardService.individualID.next(0)
    this.ddlIndividual.index = 0;
    this.ddlIndividual.value = '';
    this.ddlIndividual.reset();
  }

  // #endregion

  // ======================================
  // Events -> 6
  // #region "Listbox - LOAD"
  loadListboxes() {

    // ====================================
    // Kendo UI
    this.viewLob$ = this._lobsService;
    this.viewProject$ = this._projectsService;
    this.viewCompany$ = this._companiesService;
    this.viewIndividual$ = this._individualsService;

    // TODO: update query if value is 0 then pass NULL
    this._lobsService.queryListBox();
    // this._companiesService.queryListBox(this.selectedLobID, this.selectedProjectID);
    // this._individualsService.queryListBox(this.selectedLobID, this.selectedProjectID, this.selectedCompanyID);

    // #endregion
  }

  // ======================================
  // LobsListbox() {
  //   this._lobsService.getListboxHttp().subscribe(data => {
  //     this.lobsListbox = data;
  //       // tslint:disable-next-line:no-console
  //       console.log(this.lobsListbox);
  //   });
  // }

}
