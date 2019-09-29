import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChatWithPsychologistComponent } from './chat-with-psychologist.component';

describe('ChatWithPsychologistComponent', () => {
  let component: ChatWithPsychologistComponent;
  let fixture: ComponentFixture<ChatWithPsychologistComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChatWithPsychologistComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChatWithPsychologistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
