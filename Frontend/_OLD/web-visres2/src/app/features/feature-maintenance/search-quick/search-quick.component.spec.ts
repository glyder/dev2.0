import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchQuickComponent } from './search-quick.component';

describe('SearchQuickComponent', () => {
  let component: SearchQuickComponent;
  let fixture: ComponentFixture<SearchQuickComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SearchQuickComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchQuickComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
