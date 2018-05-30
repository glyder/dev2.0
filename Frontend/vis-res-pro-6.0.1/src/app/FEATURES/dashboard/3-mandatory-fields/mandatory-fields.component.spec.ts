import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MandatoryFieldsComponent } from './mandatory-fields.component';

describe('MandatoryFieldsComponent', () => {
  let component: MandatoryFieldsComponent;
  let fixture: ComponentFixture<MandatoryFieldsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MandatoryFieldsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MandatoryFieldsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
