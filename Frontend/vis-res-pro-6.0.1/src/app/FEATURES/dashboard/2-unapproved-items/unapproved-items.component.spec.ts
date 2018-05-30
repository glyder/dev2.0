import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UnapprovedItemsComponent } from './unapproved-items.component';

describe('UnapprovedItemsComponent', () => {
  let component: UnapprovedItemsComponent;
  let fixture: ComponentFixture<UnapprovedItemsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UnapprovedItemsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UnapprovedItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
