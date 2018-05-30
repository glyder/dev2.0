import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TestingHomeComponent } from './_home/testing-home.component';
import { VentiaStylesComponent } from './ventia-styles/ventia-styles.component';
import { HomeJokeComponent } from './joke/home-joke.component';

const routes: Routes = [
  // { path: '', redirectTo: 'pokemon', pathMatch: 'full' },
  // {
  //   path: 'pokemon', component: PokemonListComponent,
  //   children: [
  //     { path: ':id', component: PokemonDetailComponent }
  //   ]
  // },
  {
    path: 'joke',
    component: HomeJokeComponent
  },
  {
    path: 'ventia-styles',
    component: VentiaStylesComponent
  },
  {
    path: '',
    component: TestingHomeComponent
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TestingRoutingModule { }
