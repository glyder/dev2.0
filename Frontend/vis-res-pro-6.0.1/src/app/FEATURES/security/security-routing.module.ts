import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeSecurityComponent } from './home-security/home-security.component';

const routes: Routes = [
  {
    path: '',
    component: HomeSecurityComponent
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SecurityRoutingModule { }
