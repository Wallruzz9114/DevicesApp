import { Component, Input, OnInit } from '@angular/core';
import {
  faDesktop,
  faInfoCircle,
  faMobileAlt,
  faTabletAlt,
} from '@fortawesome/free-solid-svg-icons';
import { IDevice } from '../../models/device';

@Component({
  selector: 'app-device-list',
  templateUrl: './device-list.component.html',
  styleUrls: ['./device-list.component.scss'],
})
export class DeviceListComponent implements OnInit {
  @Input() public devices: IDevice[] = [];
  @Input() public showInfoIcon: boolean = false;

  public infoIcon = faInfoCircle;
  public phoneIcon = faMobileAlt;
  public tabletIcon = faTabletAlt;
  public desktopIcon = faDesktop;

  constructor() {}

  ngOnInit(): void {}
}
