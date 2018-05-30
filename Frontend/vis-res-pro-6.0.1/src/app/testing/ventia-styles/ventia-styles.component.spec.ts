import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VentiaStylesComponent } from './ventia-styles.component';

describe('VentiaStylesComponent', () => {
  let component: VentiaStylesComponent;
  let fixture: ComponentFixture<VentiaStylesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VentiaStylesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VentiaStylesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
