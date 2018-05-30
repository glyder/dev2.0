import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KendoTesterComponent } from './kendo-tester.component';

describe('KendoTesterComponent', () => {
  let component: KendoTesterComponent;
  let fixture: ComponentFixture<KendoTesterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KendoTesterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KendoTesterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
