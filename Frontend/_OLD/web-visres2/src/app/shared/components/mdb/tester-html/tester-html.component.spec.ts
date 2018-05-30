import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TesterHtmlComponent } from './tester-html.component';

describe('TesterHtmlComponent', () => {
  let component: TesterHtmlComponent;
  let fixture: ComponentFixture<TesterHtmlComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TesterHtmlComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TesterHtmlComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
