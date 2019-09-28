import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators} from '@angular/forms';
import { Subscription } from 'rxjs';
import { JwtService } from 'src/app/services/jwt.service';
import { Router } from '@angular/router';
import {Questionnaire} from "src/app/models/questionnaire";
@Component({
  selector: 'app-questionnaire',
  templateUrl: './questionnaire.component.html',
  styleUrls: ['./questionnaire.component.scss']
})
export class QuestionnaireComponent implements OnInit {
  name: string;
  sub: Subscription;
  profileForm: FormGroup; 

  constructor(
    protected JwtService: JwtService,
    private formBuilder: FormBuilder,
    protected router: Router
    ){  }

  ngOnInit() {
    this.profileForm = this.formBuilder.group({
      name:  ['', Validators.required],
      surname:  ['', Validators.required],
      middleName:  ['', Validators.required],
      birthDate:  ['', Validators.required],
      city:  ['', Validators.required],
      isRussianCitizenship:  ['', Validators.required],
      addressResidence:  ['', Validators.required],
      addressRegistration:  ['', Validators.required],
      phoneNumber:  ['', Validators.required],
      email:  ['', Validators.required]
    });
    this.sub = new Subscription;
  // this.getQuestionnaire();
  }
  get f() { return this.profileForm.controls; }
  private getQuestionnaire(){
    const questionnaire: Questionnaire = {
      name:  this.f.name.value,
      surname: this.f.surname.value,
      middleName: this.f.middleName.value,
      birthDate:  this.f.birthDate.value,
      city: this.f.city.value,
      isRussianCitizenship: this.f.isRussianCitizenship.value,
      addressResidence: this.f.addressResidence.value,
      addressRegistration: this.f.addressRegistration.value,
      phoneNumber: this.f.phoneNumber.value,
      email: this.f.email.value,
    }
    if(questionnaire.name !== "" ) {
      this.sub.add(this.JwtService.postQuestionnaire(questionnaire).subscribe(d => console.log(d)));
      window.alert("Успешно отправилось"); }
      else{ window.alert("Есть пустые поля. Анкета не отправлена."); }
  }
  onSubmit() {
    // TODO: Use EventEmitter with form value
    //this.getQuestionnaire();
    //console.warn(this.profileForm.value);
  }
}
