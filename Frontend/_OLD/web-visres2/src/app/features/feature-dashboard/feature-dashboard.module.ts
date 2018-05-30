import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FeatureDashboardRoutingModule } from './feature-dashboard-routing.module';

import { ExpiredItemsComponent } from './expired-items/expired-items.component';
import { UnapprovedItemsComponent } from './unapproved-items/unapproved-items.component';
import { MissingUnapprovedItemsComponent } from './missing-unapproved-items/missing-unapproved-items.component';
import { LandingComponent } from './landing/landing.component';

@NgModule({
  imports: [
    CommonModule,
    FeatureDashboardRoutingModule
  ],
  declarations: [ExpiredItemsComponent, UnapprovedItemsComponent, MissingUnapprovedItemsComponent, LandingComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA]
})
export class FeatureDashboardModule {

 }
