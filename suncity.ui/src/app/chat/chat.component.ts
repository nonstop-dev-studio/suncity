import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { Subscription } from 'rxjs';
import { JwtService } from 'src/app/services/jwt.service';
import { Router } from '@angular/router';
import { getDialog } from 'src/app/models/dialog';
import { postDialog } from 'src/app/models/dialog';
import { FormGroup, FormControl, FormBuilder, Validators} from '@angular/forms';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})
export class ChatComponent implements OnInit {
  getDialog: getDialog[];
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
      nameDialog:  ['', Validators.required]
    });
    this.sub = new Subscription();
    this.getData();
  }
  get f() { return this.profileForm.controls; }
  private addDialog(){
    const postDialog: postDialog = {
      name:  this.f.nameDialog.value,
      firstHuman: "",
      secondHuman: ""
    }
      this.sub.add(this.jwtService.postDialog(postDialog).subscribe(d => console.log(d)));
      this.getData();
  }
  private getData(){
    this.sub.add(
      this.jwtService.getDialog().subscribe((d: getDialog[])=>{
        this.getDialog = d;
        this.cdr.markForCheck();
      })
    );
  }
  ngOnDestroy(){
    this.sub.unsubscribe();
  }
  navigateTo(id) {
    this.router.navigateByUrl('dialog/' + id);
  }
}
