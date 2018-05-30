import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FeatureSearchRoutingModule } from './feature-search-routing.module';
import { SearchListComponent } from './search-list/search-list.component';

@NgModule({
  imports: [
    CommonModule,
    FeatureSearchRoutingModule
  ],
  declarations: [SearchListComponent]
})
export class FeatureSearchModule { }
