import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { DeviceListComponent } from '../../components/device-list/device-list.component';
import { MockDeviceService } from '../../mock/mock.device.service';
import { DeviceService } from '../../services/device.service';
import { DevicesPageComponent } from './devices-page.component';

describe('DevicesPageComponent', () => {
  let component: DevicesPageComponent;
  let fixture: ComponentFixture<DevicesPageComponent>;
  let mockDeviceService: MockDeviceService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RouterTestingModule.withRoutes([])],
      declarations: [DevicesPageComponent, DeviceListComponent],
      providers: [{ provide: DeviceService, useClass: mockDeviceService }],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should fetch devices correctly from the service', () => {
    fixture.detectChanges();
    expect(fixture.componentInstance.allDevices.length).toBe(6);
  });
});
