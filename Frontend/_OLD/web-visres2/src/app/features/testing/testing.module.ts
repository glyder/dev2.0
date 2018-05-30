import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';

// Routing
import { TestingRoutingModule } from './testing-routing.module';

// VRS Modules
import { CoreModule } from './../../core/core.module';
import { SharedModule } from './../../shared/shared.module';

// Components
import { MdbComponent } from './mdb/mdb.component';
import { NgMaterialComponent } from './ng-material/ng-material.component';

import { NgrxComponent } from './ngrx/ngrx.component';
import { VrsUiComponent } from './vrs-ui/vrs-ui.component';


@NgModule({
  imports: [
    CommonModule,
    TestingRoutingModule,

    CoreModule,
    SharedModule
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA],
  providers: [],
  exports: [
  ],
  declarations: [NgMaterialComponent, MdbComponent,
                 NgrxComponent, VrsUiComponent]
})
export class TestingModule { }
