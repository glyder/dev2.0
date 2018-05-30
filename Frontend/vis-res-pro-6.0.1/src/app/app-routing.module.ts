import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Core - Guards
import { AuthGuard } from '@vrs/core/guards/index';

// Components
import { HomeComponent } from '@vrs/public/home/index';
import { LoginComponent } from '@vrs/public/login/index';
import { RegisterComponent } from '@vrs/public/register/index';


// REMOVE!!!!!
// import { HomeComponent } from './home/home.component';     // Add your component here

const routes: Routes = [

    // =========================
    // Features
    {
        path: 'dashboard',
        loadChildren: 'app/FEATURES/dashboard/dashboard.module#DashboardModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'maintenance',
        loadChildren: 'app/FEATURES/maintenance/maintenance.module#MaintenanceModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'myaccount',
        loadChildren: 'app/FEATURES/myaccount/myaccount.module#MyaccountModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'myprojects',
        loadChildren: 'app/FEATURES/myprojects/myprojects.module#MyprojectsModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'reports',
        loadChildren: 'app/FEATURES/reports/reports.module#ReportsModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'security',
        loadChildren: 'app/FEATURES/security/security.module#SecurityModule',
        canActivate: [AuthGuard]
    },

    // =========================
    // Testing - Internal
    {
        path: 'testing',
        loadChildren: 'app/testing/testing.module#TestingModule',
        // canActivate: [AuthGuard]
    },

    // ====================================================================

    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },

    // otherwise redirect to home
    { path: '**', redirectTo: '' },



    // // =========================
    // // Login
    // {
    //     path: 'login',
    //     loadChildren: 'app/login/login.module#LoginModule',
    // },



    // =========================
    // Component
    // {
    //     path: 'home',
    //     component: HomeComponent
    // },

    // =========================
    // HOME
    // {
    //     path: '',
    //     component: HomeComponent
    // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
