import { Injectable } from '@angular/core';

import { Observable } from 'rxjs/Observable';
import { map } from 'rxjs/operators/map';

import { ApiService } from './../api.service';

@Injectable()
export class ApiTagsService {

  constructor (
    private apiService: ApiService
  ) {}

  getAll(): Observable<[string]> {
    return this.apiService.get('/tags')
          .pipe(map(data => data.tags));
  }

}
