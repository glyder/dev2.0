import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestingRoutingModule } from './testing-routing.module';

// Components
import { TestingHomeComponent } from './_home/testing-home.component';
import { VentiaStylesComponent } from './ventia-styles/ventia-styles.component';
import { HomeJokeComponent, JokeComponent, JokeFormComponent, JokeListComponent } from './joke';

// Providers
import { SimulateHttpService } from '@vrs/testing/_services/simulate-http.service';

@NgModule({
  imports: [
    CommonModule,
    TestingRoutingModule
  ],
  declarations: [
    TestingHomeComponent,
    JokeComponent, JokeFormComponent, JokeListComponent, HomeJokeComponent,
    VentiaStylesComponent
  ],
  exports: [
    // JokeComponent, JokeFormComponent, JokeListComponent, HomeJokeComponent
  ],
  providers: [
    SimulateHttpService
  ],
  schemas:   [ NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA ]
})
export class TestingModule { }
