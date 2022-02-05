import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoginFormComponent } from './auth/components/login-form/login-form.component';
import { CoreRoutingModule } from './core-routing.module';
import { LoginPageComponent } from './pages/login-page/login-page.component';

@NgModule({
  declarations: [LoginFormComponent, LoginPageComponent],
  imports: [CommonModule, CoreRoutingModule, FormsModule, ReactiveFormsModule, HttpClientModule],
})
export class CoreModule {}
