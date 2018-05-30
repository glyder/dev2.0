import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeMyaccountComponent } from './home-myaccount/home-myaccount.component';

const routes: Routes = [
  {
    path: '',
    component: HomeMyaccountComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MyaccountRoutingModule { }
