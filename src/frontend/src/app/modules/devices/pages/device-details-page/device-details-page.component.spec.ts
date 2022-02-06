import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DeviceDetailsPageComponent } from './device-details-page.component';

describe('DeviceDetailsPageComponent', () => {
  let component: DeviceDetailsPageComponent;
  let fixture: ComponentFixture<DeviceDetailsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeviceDetailsPageComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeviceDetailsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });
});
