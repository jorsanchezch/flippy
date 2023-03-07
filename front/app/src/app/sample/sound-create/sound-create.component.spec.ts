import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SoundCreateComponent } from './sound-create.component';

describe('SoundCreateComponent', () => {
  let component: SoundCreateComponent;
  let fixture: ComponentFixture<SoundCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SoundCreateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SoundCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
