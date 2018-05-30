// AppComponent
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { AppComponent } from './app.component';               // App Component!
import { AppRoutingModule } from './app-routing.module';      // Routing


// Angular Imports
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';



// Modules
import { SharedModule } from '@vrs/shared/shared.module';                 // SHARED LIBRARY
import { CoreModule } from '@vrs/core/core.module';                       // CORE - this!!!
import { TestingModule } from '@vrs/testing/testing.module';              // TEST LIBRARY

// Imports
import { ToastModule } from '@vrs/typescripts/pro/alerts/toast/toast.module';


// PUBLIC - Components
import { HomeComponent } from '@vrs/public/home/index';
import { LoginComponent } from '@vrs/public/login/index';
import { RegisterComponent } from '@vrs/public/register/index';

@NgModule({
  imports: [
    // AppComponent
    AppRoutingModule,

    // Global & Mdbootstrap
    BrowserModule, BrowserAnimationsModule,

    ToastModule.forRoot(),

    // Modules
    CoreModule,          // Singleton Objects - UI - MDB, Material Design
    SharedModule,        // Shared (multi-instance) objects
    TestingModule,    
  ],
  declarations: [
    AppComponent,

    // public components
    HomeComponent, LoginComponent, RegisterComponent,
  ],
  exports: [
    SharedModule,     // UI, MDB/Material/Kendo, Directives
    CoreModule,       // Layout, Services
    TestingModule,

    ToastModule
  ],
  providers: [

  ],
  bootstrap: [ AppComponent ],
  schemas:   [ NO_ERRORS_SCHEMA ]
})
export class AppModule { }
