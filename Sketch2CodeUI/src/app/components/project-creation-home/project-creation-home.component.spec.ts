import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectCreationHomeComponent } from './project-creation-home.component';

describe('ProjectCreationHomeComponent', () => {
  let component: ProjectCreationHomeComponent;
  let fixture: ComponentFixture<ProjectCreationHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProjectCreationHomeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProjectCreationHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
