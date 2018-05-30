import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FeatureAdminRoutingModule } from './feature-admin-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';

@NgModule({
  imports: [
    CommonModule,
    FeatureAdminRoutingModule
  ],
  declarations: [DashboardComponent]
})
export class FeatureAdminModule { }
