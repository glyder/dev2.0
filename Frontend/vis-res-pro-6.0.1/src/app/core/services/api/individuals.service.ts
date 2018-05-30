// #region "Angular"

import { Injectable } from '@angular/core';
import { environment } from '@vrs/../environments/environment';

import { HttpClient } from '@angular/common/http';

// #endregion

// #region "RxJS"
  import { BehaviorSubject } from 'rxjs/BehaviorSubject';
  import { Observable } from 'rxjs/Observable';
  import { map } from 'rxjs/operators/map';
// #endregion

// #region "Services/Models"
import { ApiService } from './../api.service';
import { LOBs, ListBoxModel } from '@vrs/models';
// #endregion

@Injectable({
  providedIn: 'root'
})
export class IndividualsService extends BehaviorSubject<any>  {

  // httpAll = `${environment.appApi.baseUrl}/maintenance/Lobs`;
  // httpAllSP = `${environment.appApi.baseUrl}/maintenance/Lobs/SP`;
  // httpGetById = `${environment.appApi.baseUrl}/maintenance/Lobs/{id}`;
  httpListbox = `${environment.appApi.baseUrl}/maintenance/Individuals/Individuals-Listbox`;

  private BASE_URL = 'http://localhost:65464/api/';
  private methodListbox = 'maintenance/Individuals/Individuals-Listbox';

  constructor (private _apiService: ApiService,
               private http: HttpClient) {
    super(null);
  }

  // =======================================

  public queryListBox(lobID?: number, projectID?: number, companyID?: number): void {

    this.fetchListBox(lobID, projectID, companyID)
        .subscribe((x: any) => super.next(x));
  }

  private fetchListBox(lobID?: number, projectID?: number, companyID?: number): any {

    const _lobID = (lobID) ? lobID.toString() : '';
    const _projectID = (projectID) ? projectID.toString() : '';
    const _companyID = (companyID) ? companyID.toString() : '';

    const queryStr = `lobID=${_lobID}&projectID=${_projectID}&companyID=${_companyID}&$skip=0&$count=true`;

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
               .get(`/maintenance/Individuals`)  // `/articles/${slug}/comments`
               .pipe(map(data => data.lobs));
  }

  getListbox(): Observable<ListBoxModel> {

    return this._apiService.get('/maintenance/Individuals/Individuals-Listbox')
                           .pipe(map((data: {listbox: ListBoxModel}) => data.listbox));
  }

  getListboxHttp(): Observable<any[]> {

    return this.http.get<any[]>(this.httpListbox);
  }

  // =======================================
  // destroy(commentId, articleSlug) {
  //   return this.apiService
  //              .delete(`/articles/${articleSlug}/comments/${commentId}`);
  // }


}

