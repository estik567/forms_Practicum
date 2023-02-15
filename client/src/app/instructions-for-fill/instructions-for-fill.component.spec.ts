import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InstructionsForFillComponent } from './instructions-for-fill.component';

describe('InstructionsForFillComponent', () => {
  let component: InstructionsForFillComponent;
  let fixture: ComponentFixture<InstructionsForFillComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InstructionsForFillComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InstructionsForFillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
