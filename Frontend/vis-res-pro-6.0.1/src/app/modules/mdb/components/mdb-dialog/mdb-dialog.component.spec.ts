import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MdbDialogComponent } from './mdb-dialog.component';

describe('MdbDialogComponent', () => {
  let component: MdbDialogComponent;
  let fixture: ComponentFixture<MdbDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MdbDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MdbDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
