import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { Subscription } from 'rxjs';
import { JwtService } from 'src/app/services/jwt.service';
import { Router } from '@angular/router';
import { QuestionnaireComponent } from 'src/app/questionnaire/questionnaire.component';
import { Questionnaire } from 'src/app/models/questionnaire';
@Component({
  selector: 'app-questionnaire-show',
  templateUrl: './questionnaire-show.component.html',
  styleUrls: ['./questionnaire-show.component.scss']
})
export class QuestionnaireShowComponent implements OnInit,OnDestroy  {
  questionnaire: Questionnaire[];
  sub: Subscription;
  constructor(
    protected jwtService: JwtService,
    protected cdr: ChangeDetectorRef,
    protected router: Router
  ) { }

  ngOnInit() {
    this.sub = new Subscription();
    this.getData();
  }
  private getData(){
    this.sub.add(
      this.jwtService.getQuestionnaire().subscribe((q: Questionnaire[])=>{
        this.questionnaire = q;
        this.cdr.markForCheck();
      })
    );
  }
  ngOnDestroy(){
    this.sub.unsubscribe();
  }

}
