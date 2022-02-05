import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './modules/core/auth/guards/auth.guard';
import { LoginPageComponent } from './modules/core/pages/login-page/login-page.component';
import { DeviceDetailsPageComponent } from './modules/devices/pages/device-details-page/device-details-page.component';
import { DevicesPageComponent } from './modules/devices/pages/devices-page/devices-page.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'devices',
    pathMatch: 'full',
  },
  {
    path: 'login',
    component: LoginPageComponent,
  },
  {
    path: '',
    canActivate: [AuthGuard],
    runGuardsAndResolvers: 'always',
    children: [
      { path: 'devices', component: DevicesPageComponent },
      {
        path: 'devices/:id',
        component: DeviceDetailsPageComponent,
      },
    ],
  },
  { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
