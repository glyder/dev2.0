import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, Router, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';

import { ApiUserService } from './core';
import { take } from 'rxjs/operators/take';

@Injectable()
export class AppAuthResolver implements Resolve<boolean> {

  constructor(private router: Router,
              private userService: ApiUserService) {
  }

  resolve(route: ActivatedRouteSnapshot,
          state: RouterStateSnapshot
  ): Observable<boolean> {

    return this.userService.isAuthenticated.pipe(take(1));

  }
}
