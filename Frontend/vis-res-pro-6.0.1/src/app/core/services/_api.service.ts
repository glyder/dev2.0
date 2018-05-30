import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';  // HttpHeaders

// rxjs
import { Observable } from 'rxjs/Observable';
import { ErrorObservable } from 'rxjs/observable/ErrorObservable';
import { catchError } from 'rxjs/operators/catchError';

// VRS
import { environment } from '@vrs/../environments/environment';
// import { JwtService } from './security/jwt.service';


@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(
    private http: HttpClient,
    // private jwtService: JwtService
  ) {

  }

  private formatErrors(error: any) {
    return new ErrorObservable(error.error);
  }

  get(path: string, params: HttpParams = new HttpParams()): Observable<any> {
    return this.http.get(`${environment.appApi.baseUrl}${path}`, { params })
      .pipe(catchError(this.formatErrors));
  }

  put(path: string, body: Object = {}): Observable<any> {
    return this.http.put(
      `${environment.appApi.baseUrl}${path}`,
      JSON.stringify(body)
    ).pipe(catchError(this.formatErrors));
  }

  post(path: string, body: Object = {}): Observable<any> {
    return this.http.post(
      `${environment.appApi.baseUrl}${path}`,
      JSON.stringify(body)
    ).pipe(catchError(this.formatErrors));
  }

  delete(path: any): Observable<any> {
    return this.http.delete(
      `${environment.appApi.baseUrl}${path}`
    ).pipe(catchError(this.formatErrors));
  }
}
