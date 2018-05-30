import { Injectable, } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, Router, RouterStateSnapshot } from '@angular/router';

import { Observable } from 'rxjs/Observable';
import { catchError } from 'rxjs/operators/catchError';

import { ApiArticlesService, ApiUserService } from '../core';
import { Article } from './../models/test';


@Injectable()
export class ArticleResolver implements Resolve<Article> {
  constructor(
    private articlesService: ApiArticlesService,
    private router: Router,
    private userService: ApiUserService
  ) {}

  resolve(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<any> {

    return this.articlesService.get(route.params['slug'])
      .pipe(catchError((err) => this.router.navigateByUrl('/')));
  }
}
