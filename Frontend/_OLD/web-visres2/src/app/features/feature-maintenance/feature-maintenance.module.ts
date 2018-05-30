import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FeatureMaintenanceRoutingModule } from './feature-maintenance-routing.module';
import { SearchQuickComponent } from './search-quick/search-quick.component';

@NgModule({
  imports: [
    CommonModule,
    FeatureMaintenanceRoutingModule
  ],
  declarations: [SearchQuickComponent]
})
export class FeatureMaintenanceModule { }
