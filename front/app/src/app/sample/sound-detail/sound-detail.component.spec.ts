import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SoundDetailComponent } from './sound-detail.component';

describe('SoundDetailComponent', () => {
  let component: SoundDetailComponent;
  let fixture: ComponentFixture<SoundDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SoundDetailComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SoundDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
