import { Component, OnInit } from '@angular/core';
import { IDevice } from '../../models/device';
import { DeviceService } from '../../services/device.service';

@Component({
  selector: 'app-devices-page',
  templateUrl: './devices-page.component.html',
  styleUrls: ['./devices-page.component.scss'],
})
export class DevicesPageComponent implements OnInit {
  public searchInput: string = '';
  public searchResults: IDevice[] = [];
  public allDevices: IDevice[] = [];

  constructor(private _deviceService: DeviceService) {}

  ngOnInit(): void {
    this._deviceService.getAllDevices().subscribe((response) => {
      if (response) {
        this.allDevices = response;
        this.searchResults = response;
      } else {
        this.allDevices = this._deviceService.mockDevices;
        this.searchResults = this._deviceService.mockDevices;
      }
    });
  }

  public search = (inputText: string): void => {
    this.searchResults = this.allDevices.filter((x) =>
      x.name.toLowerCase().includes(inputText.toLowerCase())
    );
  };
}
