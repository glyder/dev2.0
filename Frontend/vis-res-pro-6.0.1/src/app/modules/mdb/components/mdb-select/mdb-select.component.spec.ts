import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbSelectComponent } from './mdb-select.component';

describe('MdbSelectComponent', () => {
  let component: MdbSelectComponent;
  let fixture: ComponentFixture<MdbSelectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbSelectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbSelectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
