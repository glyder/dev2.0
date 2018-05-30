import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { AlertService, AuthenticationService } from '@vrs/core';

@Component({
    moduleId: module.id.toString(),
    templateUrl: 'login.component.html',
})

export class LoginComponent implements OnInit {
    model: any = {};

    loading = false;
    returnUrl: string;
    _data: any;

    isAuthenticated: boolean;
    isAccepted: boolean;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private authenticationService: AuthenticationService,
        private alertService: AlertService) {

    }

    ngOnInit() {
        this.isAuthenticated = false;
        this.isAccepted = false;

        // reset login status
        this.authenticationService.logout();

        // get return url from route parameters or default to '/'
        this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
    }

    login() {

        this.loading = true;

        this.authenticationService.login(this.model.username, this.model.password)
            .subscribe(
                data => {
                    this.isAuthenticated = true;
                    this._data = data;

                    this.acceptTermsConditions();
                },
                error => {
                    this.isAuthenticated = false;

                    this.alertService.error(error);
                    this.loading = false;
                });
    }

    acceptTermsConditions() {
        // this.router.navigate([this.returnUrl], this._data);
    }

    continue() {
        if (this.isAccepted) {
            this.router.navigate([this.returnUrl], this._data);
        }
    }

    logout() {
        this.isAuthenticated = false;
    }
}
