import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
// import {Http} from '@angular/http';

import { Observable } from 'rxjs/Observable';
// import {map} from 'rxjs/operators';

import { environment } from '@vrs/../environments/environment';
import { Book } from '@vrs/models';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient ) {

  }

  index(): Observable<Book[]> {
    return this.http
               .get<Book[]>(`${environment.appApi.baseUrl}/test/books`);

  }

  show(bookId: number): Observable<Book> {
    return this.http
               .get<Book>(`${environment.appApi.baseUrl}/test/books/${bookId}`);

  }

  create(book: Book): Observable<Book> {
    return this.http
               .post<Book>(`${environment.appApi.baseUrl}/test/books`, book);
  }

  // update(book: Book): Observable<Book> {
  //   return this.http.patch<Book>(`${environment.appApi.baseUrl}/test/books/${book.id}`, book);
  // }


  destroy(id: number): Observable<Book> {
    return this.http
               .delete<Book>(`${environment.appApi.baseUrl}/test/books/${id}`);
  }

}
