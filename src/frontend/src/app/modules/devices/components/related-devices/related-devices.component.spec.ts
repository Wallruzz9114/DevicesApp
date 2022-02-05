import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RelatedDevicesComponent } from './related-devices.component';

describe('RelatedDevicesComponent', () => {
  let component: RelatedDevicesComponent;
  let fixture: ComponentFixture<RelatedDevicesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RelatedDevicesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RelatedDevicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
