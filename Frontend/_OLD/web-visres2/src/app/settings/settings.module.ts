import { ModuleWithProviders, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { SettingsRoutingModule } from './settings-routing.module';
import { AuthGuardGuard } from '../core';

import { SharedModule } from '../shared';
import { SettingsComponent } from './settings.component';

@NgModule({
  imports: [
    SettingsRoutingModule,
    SharedModule
  ],
  declarations: [
    SettingsComponent
  ]
})
export class SettingsModule {}
