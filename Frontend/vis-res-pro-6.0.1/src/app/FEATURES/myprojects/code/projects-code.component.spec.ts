import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectsCodeComponent } from './projects-code.component';

describe('ProjectsCodeComponent', () => {
  let component: ProjectsCodeComponent;
  let fixture: ComponentFixture<ProjectsCodeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectsCodeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectsCodeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
