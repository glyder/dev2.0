import { Injectable } from '@angular/core';
import {environment} from '@vrs/../environments/environment';

import { HttpClient } from '@angular/common/http';

import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { Observable } from 'rxjs/Observable';
import { map } from 'rxjs/operators/map';

import { ApiService } from './../api.service';

import { LOBs, ListBoxModel } from '@vrs/models';

@Injectable({
  providedIn: 'root'
})
export class CompaniesService extends BehaviorSubject<any>  {

  // httpAll = `${environment.appApi.baseUrl}/maintenance/Lobs`;
  // httpAllSP = `${environment.appApi.baseUrl}/maintenance/Lobs/SP`;
  // httpGetById = `${environment.appApi.baseUrl}/maintenance/Lobs/{id}`;
  httpListbox = `${environment.appApi.baseUrl}/maintenance/Companies/Companies-Listbox`;


  private BASE_URL = 'http://localhost:65464/api/';
  private methodListbox = 'maintenance/Companies/Companies-Listbox';

  constructor (private _apiService: ApiService,
               private http: HttpClient) {
    super(null);
  }

  // =======================================

  public queryListBox(lobID?: number, projectID?: number): void {

    if ((lobID && lobID > 0 ) &&
        (projectID && projectID > 0) ) {
      this.fetchListBox(lobID, projectID).subscribe((x: any) => super.next(x));
    } else {
      // required to reset if (lobID is reset)
      super.next(null);
    }

  }

  private fetchListBox(lobID?: number, projectID?: number): any {

    const _lobID = (lobID) ? lobID.toString() : '';
    const _projectID = (projectID) ? projectID.toString() : '';

    const queryStr = `lobID=${_lobID}&projectID=${_projectID}&$skip=0&$count=true`;

    return this.http.get(`${this.BASE_URL}${this.methodListbox}?${queryStr}`)
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
               .get(`/maintenance/Companies`)  // `/articles/${slug}/comments`
               .pipe(map(data => data.lobs));
  }

  getListbox(): Observable<ListBoxModel> {
    return this._apiService
               .get('/maintenance/Companies/Companies-Listbox')
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


