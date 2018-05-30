import { Injectable } from '@angular/core';
import {environment} from '@vrs/../environments/environment';

import { HttpClient } from '@angular/common/http';

import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { Observable } from 'rxjs/Observable';
import { map } from 'rxjs/operators/map';
// import { EmptyObservable } from 'rxjs/observable/EmptyObservable';

import { ApiService } from './../api.service';

import { LOBs, ListBoxModel } from '@vrs/models';

@Injectable({
  providedIn: 'root'
})
export class ProjectsService extends BehaviorSubject<any>  {

  // httpAll = `${environment.appApi.baseUrl}/maintenance/Lobs`;
  // httpAllSP = `${environment.appApi.baseUrl}/maintenance/Lobs/SP`;
  // httpGetById = `${environment.appApi.baseUrl}/maintenance/Lobs/{id}`;
  httpListbox = `${environment.appApi.baseUrl}/maintenance/Projects/Projects-Listbox`;


  private BASE_URL = 'http://localhost:65464/api/';
  private methodListbox = 'maintenance/Projects/Projects-Listbox';

  constructor (private _apiService: ApiService,
               private http: HttpClient) {
    super(null);
  }

  // =======================================

  public queryListBox(lobID?: number): void {

    if (lobID && lobID > 0) {
      this.fetchListBox(lobID).subscribe((x: any) => super.next(x));
    } else {
      // required to reset if (lobID is reset)
      super.next(null);
    }
  }

  private fetchListBox(lobID?: number): any {

    const _lobID: string = (lobID) ? lobID.toString() : '';
    const _queryString = `lobID=${_lobID}&$skip=0&$count=true`;

    return this.http
               .get(`${this.BASE_URL}${this.methodListbox}?${_queryString}`)
               .pipe(map((response: any) => response));
  }

  // =======================================
  // add(slug, payload): Observable<tblLOBs> {
  //   return this.apiService
  //              .post(`/articles/${slug}/comments`, { comment: { body: payload } } )
  //              .pipe(map(data => data.comment));
  // }

  // getListbox(slug: any): Observable<tblLOBs[]> {
  getAll(): Observable<LOBs[]> {

    return this._apiService
               .get(`/maintenance/Projects`)  // `/articles/${slug}/comments`
               .pipe(map(data => data.lobs));
  }

  getListbox(): Observable<ListBoxModel> {

    return this._apiService
               .get('/maintenance/Projects/Projects-Listbox')
               .pipe(map((data: {listbox: ListBoxModel}) => data.listbox));
  }

  getListboxHttp(): Observable<any[]> {

    return this.http
               .get<any[]>(this.httpListbox);
  }

  // =======================================
  // destroy(commentId, articleSlug) {
  //   return this.apiService
  //              .delete(`/articles/${articleSlug}/comments/${commentId}`);
  // }


}
