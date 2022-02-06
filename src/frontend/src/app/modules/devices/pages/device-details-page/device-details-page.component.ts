import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { mockDeviceDetails } from '../../mock/mock-data';
import { IDevice } from '../../models/device';
import { IDeviceDetails } from '../../models/device-details';
import { DeviceService } from '../../services/device.service';

@Component({
  selector: 'app-device-details-page',
  templateUrl: './device-details-page.component.html',
  styleUrls: ['./device-details-page.component.scss'],
})
export class DeviceDetailsPageComponent implements OnInit {
  public allDevices: IDevice[] = [];
  public deviceDetails!: IDeviceDetails;
  public relatedDevices!: IDevice[];

  constructor(
    private _deviceService: DeviceService,
    private _activatedRoute: ActivatedRoute,
    private _router: Router
  ) {}

  ngOnInit(): void {
    this._deviceService.getAllDevices().subscribe({
      next: (response) => {
        if (response) {
          this.allDevices = response;
        }
      },
    });

    const id = +this._activatedRoute.snapshot.params['id'];

    if (id != null) {
      this._deviceService.geDeviceById(id).subscribe({
        next: (response) => {
          this.deviceDetails = response;
          this.relatedDevices = this.allDevices.filter(
            (x) => x.status === response.status && x.id !== id
          );
        },
        error: () => {
          this.deviceDetails = mockDeviceDetails;
          this.relatedDevices = this.allDevices.filter(
            (x) => x.status === this.deviceDetails.status && x.id !== id
          );
        },
      });
    }
  }

  public goToDetails(selectedDevice: IDevice) {
    this._router.navigate([`/devices/${selectedDevice.id}`]).then(() => {
      window.location.reload();
    });
  }
}
