import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, } from '@angular/router';

import { Observable } from 'rxjs/Observable';
import { take } from 'rxjs/operators/take';

import { ApiUserService } from './api/api-user.service';


@Injectable()
export class AuthGuardGuard implements CanActivate {

  constructor(
    private router: Router,
    private userService: ApiUserService
  ) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    // return true;

    return this.userService.isAuthenticated.pipe(take(1));
  }
}
