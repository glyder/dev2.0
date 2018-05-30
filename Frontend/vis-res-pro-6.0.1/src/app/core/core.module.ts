// Design behind this?
// https://stackoverflow.com/questions/42695931/angular2-coremodule-vs-sharedmodule
// CoreModule should have only services and be imported only once in the AppModule.

// Create a CoreModule with providers for the singleton services you load when the application starts.
// Import CoreModule in the root AppModule only. Never import CoreModule in any other module.
// Consider making CoreModule a pure services module with no declarations - components are used to TEST ONLY


// THIS!
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreRoutingModule } from './core-routing.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';

// Imports
import { MdbModule } from '@vrs/modules/mdb/mdb.module';

// Components
import { FooterComponent } from './components/layout/footer/footer.component';
import { SidebarHeaderComponent } from './components/layout/sidebar-header/sidebar-header.component';

// API - Services
import { ApiService } from '@vrs/core/services/api.service';
import { DashboardService, LOBsService, ObservableDashboardService } from '@vrs/core/services';

// Provider - Login/Security
import { AuthGuard, JwtInterceptor,
         AlertService, AuthenticationService,
         UserService } from '@vrs/core';

@NgModule({
  imports: [
    // THIS!
    CommonModule, CoreRoutingModule,
    MdbModule
  ],
  declarations: [
    FooterComponent, SidebarHeaderComponent,
  ],
  exports: [
    // Components
    FooterComponent, SidebarHeaderComponent
  ],
  providers: [
    // API
    ApiService,
    DashboardService, LOBsService,

    // Observables
    ObservableDashboardService,

    // Login/Security
    AuthGuard, AlertService, AuthenticationService,
    UserService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ]
})
export class CoreModule { }
