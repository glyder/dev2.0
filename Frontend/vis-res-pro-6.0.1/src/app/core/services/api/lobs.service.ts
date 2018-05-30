
import { Injectable } from '@angular/core';
import {environment} from '@vrs/../environments/environment';

// #region "Angular libraries"
  import { HttpClient } from '@angular/common/http';
// #endregion

// #region "RxJS"
  import { BehaviorSubject } from 'rxjs/BehaviorSubject';
  import { Observable } from 'rxjs/Observable';
  import { map } from 'rxjs/operators/map';
// #endregion

// #region "Service/Model"
  import { ApiService } from '@vrs/core/services/api.service';
  import { LOBs, ListBoxModel } from '@vrs/models';  // , DropDownList
// #endregion

@Injectable({
  providedIn: 'root'
})
export class LOBsService extends BehaviorSubject<any>  {

  // httpAll = `${environment.appApi.baseUrl}/maintenance/Lobs`;
  // httpAllSP = `${environment.appApi.baseUrl}/maintenance/Lobs/SP`;
  // httpGetById = `${environment.appApi.baseUrl}/maintenance/Lobs/{id}`;
  httpListbox = `${environment.appApi.baseUrl}/maintenance/Lobs/Lobs-Listbox`;


  private BASE_URL = 'http://localhost:65464/api/';
  private methodListbox = 'maintenance/Lobs/Lobs-Listbox';

  constructor (private _apiService: ApiService,
               private http: HttpClient) {

    super(null);
  }

  // =======================================

  public queryListBox(): void {

    this.fetchListBox()
        .subscribe((x: any) => super.next(x));
  }

  private fetchListBox(): any {
    const queryStr = `$skip=0&$count=true`;

    return this.http
               .get(`${this.BASE_URL}${this.methodListbox}?${queryStr}`)
               .pipe(map((response: any) => response));
  }

  // =======================================
  // add(slug, payload): Observable<tblLOBs> {
  //   return this.apiService
  //              .post(`/articles/${slug}/comments`, { comment: { body: payload } } )
  //              .pipe(map(data => data.comment));
  // }

  // getListbox(slug: any): Observable<tblLOBs[]> {
  public  getAll(): Observable<LOBs[]> {

    return this._apiService
               .get(`/maintenance/Lobs`)  // `/articles/${slug}/comments`
               .pipe(map(data => data.lobs));
  }

  public getListbox(): Observable<ListBoxModel> {

    return this._apiService
               .get('/maintenance/Lobs/Lobs-Listbox')
               .pipe(map((data: {listbox: ListBoxModel}) => data.listbox));
  }

  public getListboxHttp(): Observable<any[]> {

    return this.http
               .get<any[]>(this.httpListbox);
  }

  // =======================================
  // destroy(commentId, articleSlug) {
  //   return this.apiService
  //              .delete(`/articles/${articleSlug}/comments/${commentId}`);
  // }

}
