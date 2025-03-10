import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnnouncementLogComponent } from './announcement-log.component';

describe('AnnouncementLogComponent', () => {
  let component: AnnouncementLogComponent;
  let fixture: ComponentFixture<AnnouncementLogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AnnouncementLogComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AnnouncementLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
