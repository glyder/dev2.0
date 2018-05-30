import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbComponentsComponent } from './mdb-components.component';

describe('MdbComponentsComponent', () => {
  let component: MdbComponentsComponent;
  let fixture: ComponentFixture<MdbComponentsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbComponentsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbComponentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
