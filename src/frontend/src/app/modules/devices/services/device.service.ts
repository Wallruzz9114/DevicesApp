import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import DeviceDetailsJson from '../../../../assets/device-details.json';
import DevicesJson from '../../../../assets/devices.json';
import { IDevice } from '../models/device';
import { IDeviceDetails } from '../models/device-details';

@Injectable({
  providedIn: 'root',
})
export class DeviceService {
  public mockDevices: IDevice[] = DevicesJson;
  public mockDeviceDetails: IDeviceDetails = DeviceDetailsJson;

  constructor(private _httpClient: HttpClient) {}

  public getAllDevices = (): Observable<IDevice[]> => {
    return this._httpClient.get<IDevice[]>(environment.apiURL + 'devices');
  };

  public geDeviceById = (id: number) => {
    return this._httpClient.get<IDevice[]>(environment.apiURL + `devices/${id}`);
  };
}
