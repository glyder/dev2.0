import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeMaintenanceComponent } from './home-maintenance/home-maintenance.component';

const routes: Routes = [
  {
    path: '',
    component: HomeMaintenanceComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MaintenanceRoutingModule { }
