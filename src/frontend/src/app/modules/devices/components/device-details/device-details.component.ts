import { Component, Input, OnInit } from '@angular/core';
import { IDeviceDetails } from '../../models/device-details';

@Component({
  selector: 'app-device-details',
  templateUrl: './device-details.component.html',
  styleUrls: ['./device-details.component.scss'],
})
export class DeviceDetailsComponent implements OnInit {
  @Input() public deviceDetails: IDeviceDetails | undefined;

  constructor() {}

  ngOnInit(): void {}
}
