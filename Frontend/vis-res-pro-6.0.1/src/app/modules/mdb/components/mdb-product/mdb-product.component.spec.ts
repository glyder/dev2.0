import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbProductComponent } from './mdb-product.component';

describe('MdbProductComponent', () => {
  let component: MdbProductComponent;
  let fixture: ComponentFixture<MdbProductComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbProductComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
