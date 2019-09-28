import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators} from '@angular/forms';
import { Subscription } from 'rxjs';
import { JwtService } from 'src/app/services/jwt.service';
import { Router } from '@angular/router';
import { Report} from '../models/report';
@Component({
  selector: 'app-report-add',
  templateUrl: './report-add.component.html',
  styleUrls: ['./report-add.component.scss']
})
export class ReportAddComponent implements OnInit {
  sub: Subscription;
  profileForm: FormGroup; 
  constructor(
    protected JwtService: JwtService,
    private formBuilder: FormBuilder,
    protected router: Router
    ){  }
    ngOnInit() {
      this.profileForm = this.formBuilder.group({
        date:  ['', Validators.required],
        child:  ['', Validators.required],
        duration:  ['', Validators.required],
        whatDidYouPlanToDoAtTheMeeting:  ['', Validators.required],
        whatDidYouEndUpDoing:  ['', Validators.required],
        assessTheMoodOfTheChildBeforeAndAfterTheMeeting:  ['', Validators.required],
        targetForNextMeeting:  ['', Validators.required],
        describeYourMoodAfterTheMeeting:  ['', Validators.required],
        additionalComment:  ['', Validators.required],
        Questions:  ['', Validators.required]
      });
      this.sub = new Subscription;
    // this.getQuestionnaire();
    }
    get f() { return this.profileForm.controls; }
    private postReport(){
      const report: Report = {
        date:  this.f.date.value,
        child:  this.f.child.value,
        mentor:  "",
        status: "Ожидает проверки",
        duration:  this.f.duration.value,
        whatDidYouPlanToDoAtTheMeeting:  this.f.whatDidYouPlanToDoAtTheMeeting.value,
        whatDidYouEndUpDoing: this.f.whatDidYouEndUpDoing.value,
        assessTheMoodOfTheChildBeforeAndAfterTheMeeting:  this.f.assessTheMoodOfTheChildBeforeAndAfterTheMeeting.value,
        targetForNextMeeting:  this.f.targetForNextMeeting.value,
        describeYourMoodAfterTheMeeting: this.f.describeYourMoodAfterTheMeeting.value,
        additionalComment:  this.f.additionalComment.value,
        Questions:  this.f.Questions.value
      }
      if(report.child !== "" ) {
        this.sub.add(this.JwtService.postReport(report).subscribe(d => console.log(d)));
        window.alert("Успешно отправилось"); }
        else{ window.alert("Есть пустые поля. Отчет не отправлен."); }
    }
    onSubmit() {
      // TODO: Use EventEmitter with form value
      //this.getQuestionnaire();
      //console.warn(this.profileForm.value);
    }
}
