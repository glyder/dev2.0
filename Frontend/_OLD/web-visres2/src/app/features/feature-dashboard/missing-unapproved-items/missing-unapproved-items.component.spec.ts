import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MissingUnapprovedItemsComponent } from './missing-unapproved-items.component';

describe('MissingUnapprovedItemsComponent', () => {
  let component: MissingUnapprovedItemsComponent;
  let fixture: ComponentFixture<MissingUnapprovedItemsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MissingUnapprovedItemsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MissingUnapprovedItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
