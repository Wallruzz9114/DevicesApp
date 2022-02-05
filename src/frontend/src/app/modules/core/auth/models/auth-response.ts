import { IAppUser } from './app-user';

export interface IAuthResponse {
  token: string;
  user: IAppUser;
}
