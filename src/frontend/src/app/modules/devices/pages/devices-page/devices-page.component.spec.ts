import { HttpClientModule } from '@angular/common/http';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { mockDevices } from '../../mock/mock-data';
import { findComponents } from '../../mock/mock-helpers';
import { IDevice } from '../../models/device';
import { DeviceService } from '../../services/device.service';
import { DevicesPageComponent } from './devices-page.component';

describe('DevicesPageComponent', () => {
  let component: DevicesPageComponent;
  let fixture: ComponentFixture<DevicesPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DevicesPageComponent],
      imports: [HttpClientModule, RouterTestingModule],
      providers: [DeviceService],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesPageComponent);
    component = fixture.componentInstance;
    component.searchResults = mockDevices;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should display a list of 10 devices', async () => {
    const listComponent = findComponents(fixture, 'app-device-list');
    expect(listComponent.length).toEqual(1);

    listComponent.forEach((item, _) => {
      const devices = item.properties['devices'] as IDevice[];

      expect(devices.length).toEqual(10);
      expect(devices).toEqual(component.searchResults);
    });
  });
});
