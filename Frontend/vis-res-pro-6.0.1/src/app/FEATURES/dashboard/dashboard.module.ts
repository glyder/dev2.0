import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';

// Routing
import { DashboardRoutingModule } from './dashboard-routing.module';


// imports
import { SharedModule } from '@vrs/shared/shared.module';

// Components
import { HomeDashboardComponent } from './_home-dashboard/home-dashboard.component';
import { ExpiredItemsComponent } from './1-expired-items/expired-items.component';
import { UnapprovedItemsComponent } from './2-unapproved-items/unapproved-items.component';
import { MandatoryFieldsComponent } from './3-mandatory-fields/mandatory-fields.component';

@NgModule({
  imports: [
    CommonModule,
    DashboardRoutingModule,

    SharedModule
    // MaterialModule                // TODO: THIS IS WRONG! it should already be imported. Need to move all this to core
  ],
  declarations: [
    // Components
    HomeDashboardComponent,

    ExpiredItemsComponent,
    UnapprovedItemsComponent,
    MandatoryFieldsComponent
  ],
  exports: [
    // Components
    HomeDashboardComponent,

    ExpiredItemsComponent,
    UnapprovedItemsComponent,
    MandatoryFieldsComponent
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA]
})
export class DashboardModule { }
