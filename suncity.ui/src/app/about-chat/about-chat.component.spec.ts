import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutChatComponent } from './about-chat.component';

describe('AboutChatComponent', () => {
  let component: AboutChatComponent;
  let fixture: ComponentFixture<AboutChatComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AboutChatComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutChatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
