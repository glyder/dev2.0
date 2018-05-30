import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbButtonsComponent } from './mdb-buttons.component';

describe('MdbButtonsComponent', () => {
  let component: MdbButtonsComponent;
  let fixture: ComponentFixture<MdbButtonsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbButtonsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbButtonsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
