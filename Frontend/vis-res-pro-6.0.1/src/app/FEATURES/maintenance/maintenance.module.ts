import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MaintenanceRoutingModule } from './maintenance-routing.module';
import { HomeMaintenanceComponent } from './home-maintenance/home-maintenance.component';

@NgModule({
  imports: [
    CommonModule,
    MaintenanceRoutingModule
  ],
  declarations: [HomeMaintenanceComponent]
})
export class MaintenanceModule { }
