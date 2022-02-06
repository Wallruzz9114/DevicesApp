import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IDevice } from '../models/device';
import { IDeviceDetails } from '../models/device-details';

@Injectable({
  providedIn: 'root',
})
export class DeviceService {
  constructor(private _httpClient: HttpClient) {}

  public getAllDevices = (): Observable<IDevice[]> => {
    return this._httpClient.get<IDevice[]>(environment.apiURL + 'devices');
  };

  public geDeviceById = (id: number): Observable<IDeviceDetails> => {
    return this._httpClient.get<IDeviceDetails>(environment.apiURL + `devices/${id}`);
  };
}
