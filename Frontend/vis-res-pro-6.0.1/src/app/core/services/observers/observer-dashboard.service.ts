import { Injectable } from '@angular/core';               //  Output, EventEmitter
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable({
  providedIn: 'root'
})
export class ObserverDashboardService {

  isOpen: BehaviorSubject<boolean>;

  // ****

  lobID: BehaviorSubject<number>;
  projectID: BehaviorSubject<number>;
  companyID: BehaviorSubject<number>;
  individualID: BehaviorSubject<number>;

  // ===========================================

  constructor() {
    this.isOpen = new BehaviorSubject(true);
    // ****
    this.lobID = new BehaviorSubject(1);
    this.projectID = new BehaviorSubject(0);
    this.companyID = new BehaviorSubject(0);
    this.individualID = new BehaviorSubject(0);
  }

  // ===========================================

  getLobID() {
    return this.lobID.getValue();
  }

  getProjectID() {
    return this.projectID.getValue();
  }

  getCompanyID() {
    return this.companyID.getValue();
  }

  getIndividualID() {
    return this.individualID.getValue();
  }

  // ===========================================
  toggle() {
    this.isOpen.next(!this.isOpen.getValue());
  }
  // ===========================================

}
