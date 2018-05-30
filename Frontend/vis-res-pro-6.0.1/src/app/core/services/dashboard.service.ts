import { Injectable } from '@angular/core';
import {environment} from '@vrs/../environments/environment';

import {HttpClient} from '@angular/common/http';

import {Observable} from 'rxjs/Observable';
import {map} from 'rxjs/operators';

import { InsuranceTypeNumberExpiredViewModel } from '@vrs/models';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  httpCompanyExpiredInsurances = `${environment.appApi.baseUrl}/dashboard/expired-items/company/expired-insurances`;
  httpCompanyExpiredInsurances2 = `/dashboard/expired-items/company/expired-insurances`;
       httpCompanyInsuranceDue = `${environment.appApi.baseUrl}/dashboard/expired-items/company/insurance-due`;
                httpIndividual = `${environment.appApi.baseUrl}/dashboard/expired-items/individual`;
                  httpContract = `${environment.appApi.baseUrl}/dashboard/expired-items/contract`;

  constructor(private http: HttpClient,
              private apiService: ApiService) {

  }

  get(): Observable<InsuranceTypeNumberExpiredViewModel> {
    return this.apiService.get(this.httpCompanyExpiredInsurances2) // '/profiles/' + username)
      .pipe(map((data: {profile: InsuranceTypeNumberExpiredViewModel}) => data.profile));
  }


  CompanyRecordsExpiredInsurances(lobID: number,
                                  projectID: number,
                                  companyID: number,
                                  // individualID: number
                                ): Observable<InsuranceTypeNumberExpiredViewModel[]> {

    const queryStr = `?lobID=${lobID}&projectID=${projectID}&companyID=${companyID}`; // &individualsID=${individualID}`;
    // console.log(queryStr);

    return this.http.get<InsuranceTypeNumberExpiredViewModel[]>(this.httpCompanyExpiredInsurances + queryStr);
  }

  CompanyRecordsInsuranceDue(lobID: number,
                             projectID: number,
                             companyID: number,
                             // individualID: number
                            ): Observable<InsuranceTypeNumberExpiredViewModel[]> {

    const queryStr = `?lobID=${lobID}&projectID=${projectID}&companyID=${companyID}`; // &individualsID=${individualID}`;
    // console.log(queryStr);

    return this.http.get<InsuranceTypeNumberExpiredViewModel[]>(this.httpCompanyInsuranceDue + queryStr);
  }

  IndividualRecords(lobID: number,
                    projectID: number,
                    companyID: number,
                    // individualID: number
                  ): Observable<InsuranceTypeNumberExpiredViewModel[]> {

    const queryStr = `?lobID=${lobID}&projectID=${projectID}&companyID=${companyID}`; // &individualsID=${individualID}`;
    // console.log(queryStr);

    return this.http.get<InsuranceTypeNumberExpiredViewModel[]>(this.httpIndividual + queryStr);
  }

  ContractRecords(lobID: number,
                  projectID: number,
                  companyID: number,
                  // individualID: number
                ): Observable<InsuranceTypeNumberExpiredViewModel[]> {

    const queryStr = `?lobID=${lobID}&projectID=${projectID}&companyID=${companyID}`; // &individualsID=${individualID}`;
    // console.log(queryStr);

    return this.http.get<InsuranceTypeNumberExpiredViewModel[]>(this.httpContract + queryStr);
  }


  // show(bookId: number): Observable<InsuranceTypeNumberExpiredViewModel> {
  //   return this.http
  //       .get<InsuranceTypeNumberExpiredViewModel>(`${environment.appApi.baseUrl}/test/books/${bookId}`);

  // }

  // create(book: InsuranceTypeNumberExpiredViewModel): Observable<InsuranceTypeNumberExpiredViewModel> {
  //   return this.http.post<InsuranceTypeNumberExpiredViewModel>(`${environment.appApi.baseUrl}/test/books`, book);
  // }

  // update(book: Book): Observable<Book> {
  //   return this.http.patch<Book>(`${environment.appApi.baseUrl}/test/books/${book.id}`, book);
  // }

  // destroy(id: number): Observable<InsuranceTypeNumberExpiredViewModel> {
  //   return this.http.delete<InsuranceTypeNumberExpiredViewModel>(`${environment.appApi.baseUrl}/test/books/${id}`);
  // }

}
