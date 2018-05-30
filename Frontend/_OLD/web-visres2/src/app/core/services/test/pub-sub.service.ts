import { Injectable } from '@angular/core';

import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';

@Injectable()
export class PubSubService {

  private subjects: Subject<any>[] = [];

  constructor() { }

  publish(eventName: string) {
      // ensure a subject for the event name exists
      this.subjects[eventName] = this.subjects[eventName] || new Subject<any>();

      // publish event
      this.subjects[eventName].next();
  }

  on(eventName: string): Observable<any> {
      // ensure a subject for the event name exists
      this.subjects[eventName] = this.subjects[eventName] || new Subject<any>();

      // return observable
      return this.subjects[eventName].asObservable();
  }
}
