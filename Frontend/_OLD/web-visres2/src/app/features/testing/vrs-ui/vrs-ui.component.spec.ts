import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VrsUiComponent } from './vrs-ui.component';

describe('VrsUiComponent', () => {
  let component: VrsUiComponent;
  let fixture: ComponentFixture<VrsUiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VrsUiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VrsUiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
