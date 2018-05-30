import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MyprojectsRoutingModule } from './myprojects-routing.module';

// Components
import { ProjectsHomeComponent } from '@vrs/FEATURES/myprojects/_home/projects-home.component';
import { ProjectsCodeComponent } from '@vrs/FEATURES/myprojects/code/projects-code.component';
import { ProjectsDetailsComponent } from '@vrs/FEATURES/myprojects/details/projects-details.component';
import { ProjectsLobComponent } from '@vrs/FEATURES/myprojects/lob/projects-lob.component';
import { ProjectsMatrixComponent } from '@vrs/FEATURES/myprojects/matrix/projects-matrix.component';
import { ProjectsOnboardingComponent } from '@vrs/FEATURES/myprojects/onboarding/projects-onboarding.component';


@NgModule({
  imports: [
    CommonModule,
    MyprojectsRoutingModule
  ],
  declarations: [ProjectsHomeComponent,
                 ProjectsCodeComponent, ProjectsDetailsComponent, ProjectsLobComponent,
                 ProjectsMatrixComponent, ProjectsOnboardingComponent]
})
export class MyprojectsModule { }
