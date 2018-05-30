import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectsMatrixComponent } from './projects-matrix.component';

describe('ProjectsMatrixComponent', () => {
  let component: ProjectsMatrixComponent;
  let fixture: ComponentFixture<ProjectsMatrixComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectsMatrixComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectsMatrixComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
