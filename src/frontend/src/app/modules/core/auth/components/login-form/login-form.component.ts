import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ILoginInput } from '../../models/login-input';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss'],
})
export class LoginFormComponent implements OnInit {
  public loginInput!: ILoginInput;
  public loginForm!: FormGroup;

  constructor(
    private _authService: AuthService,
    private _formBuilder: FormBuilder,
    private _router: Router
  ) {}

  ngOnInit(): void {
    this.initializeForm();
  }

  public initializeForm = (): void => {
    this.loginForm = this._formBuilder.group({
      email: ['', Validators.required],
      password: ['', Validators.required],
    });
  };

  public login = (): void => {
    if (this.loginForm.valid) {
      this.loginInput = Object.assign({}, this.loginForm.value);

      if (this.loginInput != null) {
        this._authService.login(this.loginInput).subscribe({
          next: () => this._router.navigate(['/devices']),
          error: () => {
            console.log('Error! Check your login input');
          },
        });
      }
    }
  };
}
