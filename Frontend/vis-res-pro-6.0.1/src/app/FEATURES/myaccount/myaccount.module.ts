import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MyaccountRoutingModule } from './myaccount-routing.module';
import { HomeMyaccountComponent } from './home-myaccount/home-myaccount.component';

@NgModule({
  imports: [
    CommonModule,
    MyaccountRoutingModule
  ],
  declarations: [HomeMyaccountComponent]
})
export class MyaccountModule { }
