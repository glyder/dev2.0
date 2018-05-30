// http://jasonwatmore.com/post/2017/04/19/angular-2-4-router-animation-tutorial-example


// NO_ERRORS_SCHEMA - tells compiler to not error based on unknown elements, which are used by MdBootstrap
 import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
// import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AppRoutingModule, routedComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { environment } from '../environments/environment';


import { ToastModule } from './typescripts/pro/alerts/toast/toast.module';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MDBBootstrapModule } from './typescripts/free';
import { MDBBootstrapModulePro } from './typescripts/pro/index';
import { AgmCoreModule } from '@agm/core';
// import { AppComponent } from './app.component';
import { MDBSpinningPreloader } from './typescripts/pro/index';

// import { ServiceWorkerModule } from '@angular/service-worker';

// MaterialModule, Bootstrap
// import { UiModule } from './ui/ui.module';
// import { ContentModule } from './content/content.module';

import { CoreModule } from './core/core.module';
// import { SharedModule } from './shared/shared.module';

// import 'rxjs/add/operator/catch';
// import 'rxjs/add/operator/map';
// // import 'rxjs/Rx';

import { AuthService, ProductService, PubSubService } from './core/services';

import { AuthGuard } from './auth.guard';
import { AuthModule } from './auth/auth.module';
import { HomeModule } from './home/home.module';

import { FooterComponent, HeaderComponent, SharedModule } from './shared';


@NgModule({
  declarations: [
    AppComponent,

    FooterComponent, HeaderComponent,

    routedComponents
  ],
  imports: [
    // environment.production ? ServiceWorkerModule.register('/ngsw-worker.js') : [],

    // MDBootsrap & Angular
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpModule,
    ToastModule.forRoot(),
    MDBBootstrapModule.forRoot(),
    MDBBootstrapModulePro.forRoot(),
    AgmCoreModule.forRoot({
      // https://developers.google.com/maps/documentation/javascript/get-api-key?hl=en#key
      apiKey: 'Your_api_key'
    }),

    AppRoutingModule,

    // VR
    CoreModule,
    // SharedModule,    imported in CoreModule
    // UiModule,
    // ContentModule,
    HomeModule,
    AuthModule,
  ],
  exports: [
    BrowserModule,
    BrowserAnimationsModule,

    CoreModule,
    // SharedModule    // ,    imported in CoreModule
  ],
  // schemas: [ NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA],
  schemas: [ NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA],
  providers: [
    AuthGuard,
    MDBSpinningPreloader
  ],
  bootstrap: [AppComponent],
})

export class AppModule {

}
