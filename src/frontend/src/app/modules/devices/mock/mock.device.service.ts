import { Observable, of } from 'rxjs';
import { IDevice } from '../models/device';
import { mockDevices } from './mock-data';

export class MockDeviceService {
  public getAllDevices(): Observable<IDevice[]> {
    return of(mockDevices);
  }
}
