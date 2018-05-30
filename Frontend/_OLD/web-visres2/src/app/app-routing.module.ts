import { NgModule } from '@angular/core';

import { Routes, RouterModule, PreloadAllModules } from '@angular/router';

import { AuthGuard } from './auth.guard';
import { AppAuthResolver } from './app-auth-resolver.services';
import { LoginComponent, NotFoundComponent } from '@vrs/core/components';

import { HomeComponent } from './home';
import { ProductListComponent, ProductAddEditComponent } from './products';

// https://angular.io/guide/lazy-loading-ngmodules

export const routes: Routes = [
  // {
  //   path: 'settings',
  //   loadChildren: './settings/settings.module#SettingsModule'
  // },
  // {
  //   path: 'profile',
  //   loadChildren: './profile/profile.module#ProfileModule'
  // },
  // {
  //   path: 'editor',
  //   loadChildren: './editor/editor.module#EditorModule'
  // },
  // {
  //   path: 'article',
  //   loadChildren: './article/article.module#ArticleModule'
  // },

  // =============================================================

  {
    path: 'feature/dashboard',
    loadChildren: 'app/features/feature-dashboard/feature-dashboard.module#FeatureDashboardModule',
    canActivate: [AuthGuard]
  },
  {
    path: 'admin',
    loadChildren: 'app/features/admin/feature-admin.module#FeatureAdminModule',
    canActivate: [AuthGuard],
    // resolve: {
    //   isAuthenticated: AppAuthResolver
    // }
  },
  {
    path: 'feature/maintenance',
    loadChildren: 'app/features/feature-maintenance/feature-maintenance.module#FeatureMaintenanceModule',
    canActivate: [AuthGuard]
  },
  {
    path: 'feature/reports',
    loadChildren: 'app/features/feature-reports/feature-reports.module#FeatureReportsModule',
    canActivate: [AuthGuard]
  },
  {
    path: 'feature/search',
    loadChildren: 'app/features/feature-search/feature-search.module#FeatureSearchModule',
    canActivate: [AuthGuard] },
  {
    path: 'feature/testing',
    loadChildren: 'app/features/testing/testing.module#TestingModule'
  },
  // {
  //     path: 'products',
  //     component: ProductListComponent,
  //     children: [
  //         { path: 'add', component: ProductAddEditComponent },
  //         { path: 'edit/:id', component: ProductAddEditComponent }
  //     ]
  // },
  {
    path: 'login2', component: LoginComponent
  },
  {
    path: '', pathMatch: 'full', component: HomeComponent
  },
  {
    path: '',  redirectTo: '', pathMatch: 'full', canActivate: [AuthGuard]
  },
  {
    path: '404', component: NotFoundComponent
  },
  {
    path: '**', redirectTo: '/404'
  }
  // { path: 'customers', loadChildren: 'app/features/customers/customers.module#CustomersModule' },
  // { path: 'orders', loadChildren: 'app/features/orders/orders.module#OrdersModule'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],  // [RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })],
  exports: [RouterModule]
})
export class AppRoutingModule { }

export const routedComponents = [ProductListComponent, ProductAddEditComponent];
