import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestingHomeComponent } from './testing-home.component';

describe('TestingHomeComponent', () => {
  let component: TestingHomeComponent;
  let fixture: ComponentFixture<TestingHomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestingHomeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestingHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
