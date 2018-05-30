import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MaterialTesterComponent } from './material-tester.component';

describe('MaterialTesterComponent', () => {
  let component: MaterialTesterComponent;
  let fixture: ComponentFixture<MaterialTesterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MaterialTesterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaterialTesterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
