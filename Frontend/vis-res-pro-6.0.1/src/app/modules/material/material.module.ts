/* Material Design 5
   https://coursetro.com/posts/code/113/How-to-Build-an-Angular-5-Material-App

   This module here is as a BACKUP to MDB functionality.
*/

// TODO: https://github.com/angular/material2/issues/1071
// tslint:disable-next-line:max-line-length
// https://www.google.com.au/search?q=angular+5+material+module+features+load+material&rlz=1C1GGRV_enAU786AU786&oq=angular+5+material+module+features+load+material&aqs=chrome..69i57.25165j0j1&sourceid=chrome&ie=UTF-8
// https://stackoverflow.com/questions/48983564/lazy-loading-angular-modules-with-latest-angular-material-design-gives-error
// https://stackoverflow.com/questions/44755692/how-to-correctly-import-the-angular-material-module-through-a-shared-module-in-a

// CSS - do and delte
// https://github.com/angular/angular-cli/issues/2662
// https://theinfogrid.com/tech/developers/angular/material-icons-angular-5/

// Dialog
// https://blog.angular-university.io/angular-material-dialog/

// DataTable
// https://blog.angular-university.io/angular-material-data-table/

// HTTP
// https://blog.angular-university.io/angular-http/
// https://blog.angular-university.io/angular-jwt-authentication/

// Push Notifications
// https://blog.angular-university.io/angular-push-notifications/

// Random
// https://blog.angular-university.io/
   // https://blog.angular-university.io/angular-reactive-templates/
   // https://blog.angular-university.io/angular-app-shell/
   // https://blog.angular-university.io/angular-advanced-course/
// tslint:disable-next-line:max-line-length
   // https://blog.angular-university.io/getting-started-with-angular-setup-a-development-environment-with-yarn-the-angular-cli-setup-an-ide/
   // https://blog.angular-university.io/introduction-to-angular-2-forms-template-driven-vs-model-driven/
   // https://blog.angular-university.io/angular-2-ngfor/

import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialRoutingModule } from './material-routing.module';

// Angular
import { FormsModule } from '@angular/forms';


// Material Design 5
import {
    MatAutocompleteModule,
    MatBadgeModule,
    MatBottomSheetModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatFormFieldModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    MatTreeModule
} from '@angular/material';


// Component
import { MaterialTesterComponent } from './components/material-tester/material-tester.component'
import { MaterialDataTableComponent } from './components/material-data-table/material-data-table.component';
import { MaterialControlsComponent } from './components/material-controls/material-controls.component';


@NgModule({
  declarations: [
    // Components
    MaterialTesterComponent,
    MaterialDataTableComponent,
    MaterialControlsComponent
  ],
  imports: [
    CommonModule,
    MaterialRoutingModule,
    // Angular
    FormsModule,

    // Material Design 5
    // ====================
    MatAutocompleteModule,
    MatBadgeModule,
    MatBottomSheetModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatFormFieldModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    MatTreeModule,
//   ErrorStateMatcher,
//   ShowOnDirtyErrorStateMatcher,


  ],
  exports: [
    // Component
    MaterialTesterComponent,
    MaterialDataTableComponent,
    MaterialControlsComponent,

    // Material Design 5
    // ====================
    // CDK
    // A11yModule,
    // BidiModule,
    // ObserversModule,
    // OverlayModule,
    // PlatformModule,
    // PortalModule,
    // ScrollDispatchModule,
    // CdkStepperModule,
    // CdkTableModule,
    // CdkTreeModule,

    MatAutocompleteModule,
    MatBadgeModule,
    MatBottomSheetModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatFormFieldModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    MatTreeModule
  ],
  schemas:   [ NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA ]
})
export class MaterialModule { }
