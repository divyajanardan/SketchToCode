import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InputElementsComponent } from './input-elements.component';

describe('InputElementsComponent', () => {
  let component: InputElementsComponent;
  let fixture: ComponentFixture<InputElementsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InputElementsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InputElementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
