import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { FormBuilder, Validators, FormGroup, FormControl } from '@angular/forms';

import { ApiUserService,
         AuthService } from '@vrs/core/services';

import { Errors } from '@vrs/models/test';

// TODO: https://mdbootstrap.com/angular/components/input-validation/

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})

export class LoginComponent implements OnInit {
  form: FormGroup;

  authType: String = 'login';   // '';
  title: String = 'Sign in';
  errors: Errors = {errors: {}};
  isSubmitting = true;
  authForm: FormGroup;

  users:
    {'user':
        {
          'id': 26354,
          'email': 'test12@hotmail.com',
          'createdAt': '2018-04-15T00:44:31.211Z',
          'updatedAt': '2018-04-15T12:38:42.611Z',
          'username': 'gp',
          'bio': null,
          'image': 'https://upload.wikimedia.org/wikipedia/en/0/02/Homer_Simpson_2006.png',
          // tslint:disable-next-line:max-line-length
          'token': 'eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpZCI6MjYzNTQsInVzZXJuYW1lIjoiZ3AiLCJleHAiOjE1MjkzOTE5MDh9.c0suAskymuQ-RbWC2ssHVGSSvTccDtI9tef9L4O6BF8'
        }
    };


  constructor(private myRouter: Router,
              private route: ActivatedRoute,

              private fb: FormBuilder,
              private auth: AuthService,

              private userService: ApiUserService) {

    // this.form = fb.group({
    //      // email: ['', [Validators.required, Validators.email, this.isEmailValid('email')]],
    //      email: ['', [Validators.required]],
    //   password: ['', Validators.required]
    // });

    // use FormBuilder to create a form group
    this.authForm = this.fb.group({
      'email': ['', Validators.required],
      'password': ['', Validators.required]
    });
  }

  ngOnInit() {

    this.route.url.subscribe(data => {

      // Get the last piece of the URL (it's either 'login' or 'register')
      // this.authType = data[data.length - 1].path;
      // console.log('AuthType:' + this.authType);

      // Set a title for the page accordingly
      this.title = 'Sign in'; // (this.authType === 'login') ? 'Sign in' : 'Sign up';

      // // add form control for username if this is the register page
      // if (this.authType === 'register') {
      //   this.authForm.addControl('username', new FormControl());
      // }
    });

  }

  submitForm() {
    this.isSubmitting = true;
    this.errors = {errors: {}};

    const credentials = this.authForm.value;
    console.log('Credentials:' + credentials);

    this.userService
        .attemptAuth(this.authType, credentials)
        .subscribe(
          data => {

            // if (this.authForm.valid) {
              this.auth.sendToken(this.authForm.value.email);
              this.myRouter.navigate(['feature/dashboard']);
            // }

            // this.myRouter.navigate(['feature/dashboard']);  // this.myRouter.navigateByUrl('/')
          },
          err => {
            this.errors = err;
            this.isSubmitting = false;
          }
        );
  }

  // login() {
  //   console.log(this.form.value);

  //   if (this.form.valid) {
  //     this.auth.sendToken(this.form.value.email);
  //     this.myRouter.navigate(['feature/dashboard']);
  //   }
  // }

  // isEmailValid(control: any) {
  //   // tslint:disable-next-line:no-shadowed-variable
  //   return control => {
  //     // tslint:disable-next-line:max-line-length
  // tslint:disable-next-line:max-line-length
  //     const regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

  //     return regex.test(control.value) ? null : { invalidEmail: true };
  //   };
  // }
}

