// AppComponent
import { NgModule, NO_ERRORS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MdbRoutingModule } from './mdb-routing.module';

// Components
import { MdbHelperComponent } from './components/mdb-helper/mdb-helper.component';
import { MdbTesterComponent } from './components/mdb-tester/mdb-tester.component';
import { MdbButtonsComponent } from './components/mdb-buttons/mdb-buttons.component';
import { MdbComponentsComponent } from './components/mdb-components/mdb-components.component';
import { MdbDialogComponent } from './components/mdb-dialog/mdb-dialog.component';
import { MdbFormComponent } from './components/mdb-form/mdb-form.component';
import { MdbProductComponent } from './components/mdb-product/mdb-product.component';
import { MdbSelectComponent } from './components/mdb-select/mdb-select.component';

// Imports
// import { ToastModule } from '@vrs/typescripts/pro/alerts/toast/toast.module';
import { MDBBootstrapModule } from '@vrs/typescripts/free';
import { MDBBootstrapModulePro } from '@vrs/typescripts/pro/index';
import { AgmCoreModule } from '@agm/core';

// Provider
import { MDBSpinningPreloader } from '@vrs/typescripts/pro/index';

@NgModule({
  declarations: [
    MdbButtonsComponent,
    MdbHelperComponent,
    MdbComponentsComponent,
    MdbTesterComponent,
    MdbDialogComponent,
    MdbFormComponent,
    MdbProductComponent,
    MdbSelectComponent
  ],
  imports: [
    CommonModule, MdbRoutingModule,

    // MDB
    // ToastModule.forRoot(),
    MDBBootstrapModule.forRoot(),
    MDBBootstrapModulePro.forRoot(),
    AgmCoreModule.forRoot({
      // https://developers.google.com/maps/documentation/javascript/get-api-key?hl=en#key
      apiKey: 'Your_api_key'
    })
  ],
  exports: [
    // MDB
    // ToastModule,
    MDBBootstrapModule,
    MDBBootstrapModulePro,
    AgmCoreModule,

    // Components
    MdbHelperComponent,
    MdbTesterComponent,
    MdbButtonsComponent,
    MdbComponentsComponent,
    MdbDialogComponent,
    MdbFormComponent,
    MdbProductComponent,
    MdbSelectComponent
  ],
  providers: [
    MDBSpinningPreloader,
  ],
  schemas:   [ NO_ERRORS_SCHEMA ]
})
export class MdbModule { }
