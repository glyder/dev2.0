import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MdbComponent } from './mdb/mdb.component';
import { NgMaterialComponent } from './ng-material/ng-material.component';
import { NgrxComponent } from './ngrx/ngrx.component';
import { VrsUiComponent } from './vrs-ui/vrs-ui.component';

const routes: Routes = [
  // { path: '', redirectTo: 'pokemon', pathMatch: 'full' },
  // {
  //   path: 'pokemon', component: PokemonListComponent,
  //   children: [
  //     { path: ':id', component: PokemonDetailComponent }
  //   ]
  // },
  {
    path: 'mdb',
    component: MdbComponent
  },
  {
    path: 'material',
    component: NgMaterialComponent
  },
  {
    path: 'ngrx',
    component: NgrxComponent
  },
  {
    path: 'vrs-ui',
    component: VrsUiComponent
  },
  {
    path: '',
    component: NgMaterialComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class TestingRoutingModule { }
