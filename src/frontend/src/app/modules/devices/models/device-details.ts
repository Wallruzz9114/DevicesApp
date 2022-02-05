import { IDevice } from './device';

export interface IDeviceDetails extends IDevice {
  temperature: number;
}
