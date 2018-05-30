import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbTesterComponent } from './mdb-tester.component';

describe('MdbTesterComponent', () => {
  let component: MdbTesterComponent;
  let fixture: ComponentFixture<MdbTesterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbTesterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbTesterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
