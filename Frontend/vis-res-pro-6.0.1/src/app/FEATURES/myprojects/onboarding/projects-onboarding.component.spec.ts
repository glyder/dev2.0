import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectsOnboardingComponent } from './projects-onboarding.component';

describe('ProjectsOnboardingComponent', () => {
  let component: ProjectsOnboardingComponent;
  let fixture: ComponentFixture<ProjectsOnboardingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectsOnboardingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectsOnboardingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
