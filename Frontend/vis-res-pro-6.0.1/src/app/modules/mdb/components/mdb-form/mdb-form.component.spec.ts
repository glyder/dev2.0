import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbFormComponent } from './mdb-form.component';

describe('MdbFormComponent', () => {
  let component: MdbFormComponent;
  let fixture: ComponentFixture<MdbFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
