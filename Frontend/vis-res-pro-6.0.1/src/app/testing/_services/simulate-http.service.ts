import { Injectable } from '@angular/core';

import {Observable} from 'rxjs/Observable';
// Note: add this to enable the of and delay functionality
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/delay';

@Injectable({
  providedIn: 'root'
})
export class SimulateHttpService {

  constructor() { }


  simulateHttp(val: any, delay: number) {
      return Observable.of(val).delay(delay);
  }
}
