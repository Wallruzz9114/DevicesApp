import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IAppUser } from '../models/app-user';
import { IAuthResponse } from '../models/auth-response';
import { ILoginInput } from '../models/login-input';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  public jwtHelper = new JwtHelperService();
  public decodedToken: any;
  public currentUser: IAppUser | null = null;

  constructor(private _httClient: HttpClient) {}

  public login = (loginInput: ILoginInput): Observable<void> => {
    return this._httClient.post<IAuthResponse>(environment.apiURL + 'auth/login', loginInput).pipe(
      map((response: IAuthResponse) => {
        if (response) {
          localStorage.setItem('token', response.token);
          localStorage.setItem('user', JSON.stringify(response.user));
          this.decodedToken = this.jwtHelper.decodeToken(response.token);
          this.currentUser = response.user;
        }
      })
    );
  };

  public isLoggedIn = (): boolean => {
    const token = localStorage.getItem('token');
    if (token == null || token == '') return false;
    return token != null && !this.jwtHelper.isTokenExpired(token as string);
  };
}
