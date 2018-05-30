import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FeatureReportsRoutingModule } from './feature-reports-routing.module';

import { CoreModule } from '../../core/core.module';

import { ReportListComponent } from './report-list/report-list.component';

@NgModule({
  imports: [
    CommonModule,
    FeatureReportsRoutingModule,

    CoreModule
  ],
  declarations: [ReportListComponent]
})
export class FeatureReportsModule { }
