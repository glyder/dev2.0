import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeJokeComponent } from './home-joke.component';

describe('HomeJokeComponent', () => {
  let component: HomeJokeComponent;
  let fixture: ComponentFixture<HomeJokeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeJokeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeJokeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
