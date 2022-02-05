import { Observable, of } from 'rxjs';
import { IDevice } from '../models/device';

export class MockDeviceService {
  public getAllDevices(): Observable<IDevice[]> {
    const firstDevice: IDevice = {
      id: 1,
      name: 'Device 1',
      type: 'Monitor',
      status: 'Offline',
    };
    const secondDevice: IDevice = {
      id: 2,
      name: 'Device 2',
      type: 'Tablet',
      status: 'Available',
    };
    const thirdDevice: IDevice = {
      id: 3,
      name: 'Device 3',
      type: 'Phone',
      status: 'Available',
    };
    const fourthDevice: IDevice = {
      id: 4,
      name: 'Device 4',
      type: 'Tablet',
      status: 'Available',
    };
    const fifthDevice: IDevice = {
      id: 5,
      name: 'Device 5',
      type: 'Phone',
      status: 'Offline',
    };
    const sixthDevice: IDevice = {
      id: 6,
      name: 'Device 6',
      type: 'Monitor',
      status: 'Available',
    };

    const allDevices = [
      firstDevice,
      secondDevice,
      thirdDevice,
      fourthDevice,
      fifthDevice,
      sixthDevice,
    ];

    return of(allDevices);
  }
}
