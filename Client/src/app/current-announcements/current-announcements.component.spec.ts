import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CurrentAnnouncementsComponent } from './current-announcements.component';

describe('CurrentAnnouncementsComponent', () => {
  let component: CurrentAnnouncementsComponent;
  let fixture: ComponentFixture<CurrentAnnouncementsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CurrentAnnouncementsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CurrentAnnouncementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
