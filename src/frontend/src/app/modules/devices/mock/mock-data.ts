import DeviceDetailsJson from '../../../../assets/device-details.json';
import DevicesJson from '../../../../assets/devices.json';
import { IDevice } from '../models/device';
import { IDeviceDetails } from '../models/device-details';

export const mockDevices: IDevice[] = DevicesJson;
export const mockDeviceDetails: IDeviceDetails = DeviceDetailsJson;
