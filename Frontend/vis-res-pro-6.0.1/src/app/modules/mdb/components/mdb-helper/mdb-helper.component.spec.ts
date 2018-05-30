import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbHelperComponent } from './mdb-helper.component';

describe('MdbHelperComponent', () => {
  let component: MdbHelperComponent;
  let fixture: ComponentFixture<MdbHelperComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbHelperComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbHelperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
