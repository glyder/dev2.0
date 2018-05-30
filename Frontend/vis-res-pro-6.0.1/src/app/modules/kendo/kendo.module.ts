import { NgModule,  NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';

import { KendoRoutingModule } from './kendo-routing.module';
import { KendoTesterComponent } from './components/kendo-tester/kendo-tester.component';


// Import the ButtonsModule
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { DropDownsModule, AutoCompleteModule, ComboBoxModule } from '@progress/kendo-angular-dropdowns';

@NgModule({
  declarations: [
    KendoTesterComponent
  ],
  imports: [
    CommonModule,
    KendoRoutingModule,

    // Kendo UI - import
    ButtonsModule,
    DropDownsModule, AutoCompleteModule, ComboBoxModule
  ],
  exports: [
    // Components
    KendoTesterComponent,

    // Kendo UI - export (because sharing is caring)
    ButtonsModule,
    DropDownsModule, AutoCompleteModule, ComboBoxModule
  ],
  schemas:   [ NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA ]
})
export class KendoModule { }
