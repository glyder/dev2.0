import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreRoutingModule } from './core-routing.module';

import { BrowserModule } from '@angular/platform-browser';

// Components
import { HeaderComponent, FooterComponent, LoginComponent, NotFoundComponent,
         CoreNavSidebarComponent, CoreNavTopbarComponent
      } from '@vrs/core/components';

// Angular
import { FormsModule, ReactiveFormsModule } from '@angular/forms';     // [(ngModel)]="answer"
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { HttpTokenInterceptor } from './interceptors/http.token.interceptor';

// // MDBootstrap
// // ============
// // import { MDBBootstrapModule } from 'angular-bootstrap-md';      // FREE ONE!!! direct -> node_module
// import { ToastModule } from '@vrs/typescripts/pro/alerts/toast/toast.module';
// // import { BrowserModule } from '@angular/platform-browser';
// import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// // import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
// // import { FormsModule } from '@angular/forms';
// import { HttpModule } from '@angular/http';
// import { MDBBootstrapModule } from '@vrs/typescripts/free';
// import { MDBBootstrapModulePro } from '@vrs/typescripts/pro/index';
// import { AgmCoreModule } from '@agm/core';
// import { MDBSpinningPreloader } from '@vrs/typescripts/pro/index';


// VRS UI libraries
import { SharedModule } from '@vrs/shared/shared.module';
import { MaterialModule } from './modules/material.module';     // Wrapped
import { FlexLayoutModule } from '@angular/flex-layout';        // direct -> node_module
import { NgwWowModule } from 'ngx-wow';                         // direct -> node_module

// ngrx
import { StoreModule, Store, Action } from '@ngrx/store';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';

import { simpleReducer } from '@vrs/store';
import { postReducer } from './../store/post/post.reducer';

// Services
import { AuthService } from './services/auth.service';
import { BooksService, ContactsService } from './services/test';

// API
import { ApiService, AuthGuardGuard, JwtService } from './services';
import { ApiArticlesService, ApiCommentsService, ApiProfilesService, ApiTagsService, ApiUserService } from './services/api';

@NgModule({

  imports: [
    // NG
    CommonModule, CoreRoutingModule,
//    BrowserModule,
    FormsModule, ReactiveFormsModule, HttpClientModule,

    // // MDBootstrap
    // // =======================
    // // BrowserModule,
    // // BrowserAnimationsModule,          // App.Component
    // // FormsModule,
    // HttpModule,
    // ToastModule.forRoot(),
    // MDBBootstrapModule.forRoot(),
    // MDBBootstrapModulePro.forRoot(),
    // AgmCoreModule.forRoot({
    //   // https://developers.google.com/maps/documentation/javascript/get-api-key?hl=en#key
    //   apiKey: 'Your_api_key'
    // }),

    // VRS - UI
    SharedModule,
    MaterialModule, FlexLayoutModule,
    NgwWowModule.forRoot(),

    // NGRX
    StoreModule.forRoot({
      post: postReducer,
      message: simpleReducer
    }),

    // Redux DevTools
    StoreDevtoolsModule.instrument({
      maxAge: 10
    })

  ],

  declarations: [
    HeaderComponent, LoginComponent, NotFoundComponent, FooterComponent,
    CoreNavSidebarComponent, CoreNavTopbarComponent,
  ],

  exports: [
    // NG
    BrowserModule,
    FormsModule, ReactiveFormsModule, HttpClientModule,

    // VRS - UI Libraries
    SharedModule,
    // MDBBootstrapModule,
    MaterialModule, FlexLayoutModule, NgwWowModule,

    // Components
    HeaderComponent, FooterComponent, LoginComponent, NotFoundComponent,
    CoreNavSidebarComponent, CoreNavTopbarComponent,
  ],

  providers: [
    // Interceptors
    { provide: HTTP_INTERCEPTORS, useClass: HttpTokenInterceptor, multi: true },

    // // MDB Bootstrap
    // MDBSpinningPreloader,                 // ?? MDBoostrap - pro

    // VRS - Services
    AuthService,                          // LoggerService, ProgressBarService

    // TEST - Services...
    BooksService, ContactsService,

    // Test - API Services...
    ApiService, AuthGuardGuard, JwtService,
    ApiUserService, ApiArticlesService,  ApiCommentsService, ApiProfilesService, ApiTagsService,
  ],

  schemas: [ NO_ERRORS_SCHEMA ]
})
export class CoreModule { }
