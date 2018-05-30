import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Components
import { ProjectsHomeComponent } from './_home/projects-home.component';
import { ProjectsCodeComponent } from './code/projects-code.component';
import { ProjectsDetailsComponent } from './details/projects-details.component';
import { ProjectsLobComponent } from './lob/projects-lob.component';
import { ProjectsMatrixComponent } from './matrix/projects-matrix.component';
import { ProjectsOnboardingComponent } from './onboarding/projects-onboarding.component';


const routes: Routes = [
  {
    path: '',
    component: ProjectsHomeComponent
  },
  {
    path: 'code',
    component: ProjectsCodeComponent
  }
  ,
  {
    path: 'details',
    component: ProjectsDetailsComponent
  }
  ,
  {
    path: 'lob',
    component: ProjectsLobComponent
  }
  ,
  {
    path: 'matrix',
    component: ProjectsMatrixComponent
  }
  ,
  {
    path: 'onboarding',
    component: ProjectsOnboardingComponent
  }


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MyprojectsRoutingModule { }
