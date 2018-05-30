// Design behind this?
// https://stackoverflow.com/questions/42695931/angular2-coremodule-vs-sharedmodule
// SharedModule should have anything but services and be imported in all modules that
// need the shared stuff (which could also be the AppModule).
// HENCE: we import SharedModule into FEATURES (Except Core)
// https://angular.io/guide/sharing-ngmodules

// Create a SharedModule with the components, directives, and pipes that you use everywhere in your app.
// This module should consist entirely of declarations, most of them exported.
// The SharedModule may re-export other widget modules, such as CommonModule, FormsModule, and modules
// with the UI controls that you use most widely (ie. KendoUI, Material, MDBootstrap).
// The SharedModule should not have providers for reasons explained previously. Nor should any of its
// imported or re-exported modules have providers. If you deviate from this guideline, know what you're doing and why.
// Import the SharedModule in your feature modules, both those loaded when the app starts and those you lazy load later.

import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedRoutingModule } from './shared-routing.module';

// Modules - UI
import { MdbModule } from '@vrs/modules/mdb/mdb.module';
import { MaterialModule } from '@vrs/modules/material/material.module';
import { KendoModule } from '@vrs/modules/kendo/kendo.module';


// Angular imports
// MDB - Forms, Http, HttpClient
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule, HttpClientJsonpModule } from '@angular/common/http'; // HTTP_INTERCEPTORS

// Components
import { ButtonComponent } from './components/ui/button/button.component';

// Directive
// import { AlertComponent } from '@vrs/shared/directives/alert/index';

@NgModule({
  imports: [
    CommonModule,
    SharedRoutingModule,

    // Angular
    // MDB - Http, HttpClient, Forms
    ReactiveFormsModule, FormsModule,
    HttpModule, HttpClientModule, HttpClientJsonpModule,

    // Modules
    MdbModule, MaterialModule, KendoModule
  ],
  declarations: [
    // Component
    ButtonComponent,

    // Directive
    // AlertComponent
],
  exports: [
    // Angular
    ReactiveFormsModule, FormsModule,
    HttpModule, HttpClientModule, HttpClientJsonpModule,

    // Modules
    MdbModule, MaterialModule, KendoModule,

    // Component
    ButtonComponent
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
})
export class SharedModule { }
