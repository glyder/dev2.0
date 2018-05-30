import { Injectable } from '@angular/core';               //  Output, EventEmitter
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

// ================================================================
// #region "Observables -- Observer -- Subscriptions"

// https://stackblitz.com/edit/angular-communication-4-solution
// Obserservable -------> Value ----> End()
//                         |            |
//                    _____|            |
//                    V                 V
// Observer ----->  next(), error(), complete()
//                   __________^
//                   |
// Observable ----> Error -----> End()

// #endregion

@Injectable({
  providedIn: 'root'
})
export class ObservableDashboardService {

  public isOpen: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(true);

  // EVENTS -> 1a, 1b, 1c, 1d
  public lobID: BehaviorSubject<number> = new BehaviorSubject<number>(0);
  public projectID: BehaviorSubject<number> = new BehaviorSubject<number>(0);
  public companyID: BehaviorSubject<number> = new BehaviorSubject<number>(0);
  public individualID: BehaviorSubject<number> = new BehaviorSubject<number>(0);

  constructor() {
    // EVENTS -> 1a, 1b, 1c, 1d -> auto initialized above
  }

  toggle() {
    this.isOpen.next(!this.isOpen.getValue());
  }

  // #region "get values"

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

  // #endregion

  // #region "set values"

  setLobID(id: number) {
    return this.lobID.next(id);
  }

  setProjectID(id: number) {
    return this.projectID.next(id);
  }

  setCompanyID(id: number) {
    return this.companyID.next(id);
  }

  setIndividualID(id: number) {
    return this.individualID.next(id);
  }

  // #endregion

}
