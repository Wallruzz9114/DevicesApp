import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { mockDevices } from '../../mock/mock-data';
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

  constructor(private _deviceService: DeviceService, private _router: Router) {}

  ngOnInit(): void {
    this._deviceService.getAllDevices().subscribe({
      next: (response) => {
        if (response) {
          this.allDevices = response;
          this.searchResults = response;
        }
      },
      error: () => {
        this.allDevices = mockDevices;
        this.searchResults = mockDevices;
      },
    });
  }

  public search = (inputText: string): void => {
    this.searchResults = this.allDevices.filter((x) =>
      x.name.toLowerCase().includes(inputText.toLowerCase())
    );
  };

  public goToDetails(selectedDevice: IDevice) {
    this._router.navigate([`/devices/${selectedDevice.id}`]);
  }
}
