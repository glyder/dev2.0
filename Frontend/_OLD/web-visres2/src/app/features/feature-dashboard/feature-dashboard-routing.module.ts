import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { ExpiredItemsComponent } from './expired-items/expired-items.component';
import { LandingComponent } from './landing/landing.component';

const routes: Routes = [
  {
    path: '',
    component: LandingComponent // ExpiredItemsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FeatureDashboardRoutingModule { }
