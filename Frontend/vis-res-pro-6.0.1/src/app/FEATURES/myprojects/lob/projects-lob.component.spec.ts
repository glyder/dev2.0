import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectsLobComponent } from './projects-lob.component';

describe('ProjectsLobComponent', () => {
  let component: ProjectsLobComponent;
  let fixture: ComponentFixture<ProjectsLobComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectsLobComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectsLobComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
