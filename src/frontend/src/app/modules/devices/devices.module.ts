import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { DeviceDetailsComponent } from './components/device-details/device-details.component';
import { DeviceListComponent } from './components/device-list/device-list.component';
import { DeviceSearchComponent } from './components/device-search/device-search.component';
import { DevicesRoutingModule } from './devices-routing.module';
import { DeviceDetailsPageComponent } from './pages/device-details-page/device-details-page.component';
import { DevicesPageComponent } from './pages/devices-page/devices-page.component';

@NgModule({
  declarations: [
    DevicesPageComponent,
    DeviceDetailsPageComponent,
    DeviceListComponent,
    DeviceSearchComponent,
    DeviceDetailsComponent,
  ],
  imports: [CommonModule, DevicesRoutingModule, FontAwesomeModule],
})
export class DevicesModule {}
