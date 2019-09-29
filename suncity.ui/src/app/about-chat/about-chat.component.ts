import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { Subscription } from 'rxjs';
import { JwtService } from 'src/app/services/jwt.service';
import { Router } from '@angular/router';
import { FormGroup, FormControl, FormBuilder, Validators} from '@angular/forms';
import { Message } from 'src/app/models/message';
@Component({
  selector: 'app-about-chat',
  templateUrl: './about-chat.component.html',
  styleUrls: ['./about-chat.component.scss']
})
export class AboutChatComponent implements OnInit {
  pathname: string;
  message: Message[] = [];
  sub: Subscription;
  profileForm: FormGroup; 
  constructor(
    protected jwtService: JwtService,
    protected cdr: ChangeDetectorRef,
    private formBuilder: FormBuilder,
    protected router: Router
  ) { }

  ngOnInit() {
    this.profileForm = this.formBuilder.group({
      msg:  ['', Validators.required]
    });
    this.sub = new Subscription();
    this.getData();
  }
  private addMesage(){
    this.pathname = window.location.pathname;
    const message: Message = {
      key: window.location.pathname,
      msg: this.f.msg.value
    }
      this.sub.add(this.jwtService.postMessage(message).subscribe(d => console.log(d)));
      this.message = [];
      this.getData();
  }
  get f() { return this.profileForm.controls; }
  private getData(){
    this.sub.add(
      this.jwtService.getMessage(this.pathname).subscribe((m: Message[])=>{
        m.forEach((msg) => {
          if(msg.key == window.location.pathname) {
            this.message.push(msg);
          }
        })
        this.cdr.markForCheck();
      })
    );
  }
  pathnameButton(){
    console.log(window.location.pathname);
  }
}
