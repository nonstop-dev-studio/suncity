import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main/main.component';
import { ModuleWithProviders } from '@angular/core';
import { QuestionnaireComponent } from '../app/questionnaire/questionnaire.component';
import { LoginComponent } from './login/login.component';
import { AccountComponent } from './toolbar/account/account.component';
import { ChatComponent } from '../app/chat/chat.component';
import { FaqComponent } from '../app/faq/faq.component';
import { ReportComponent } from '../app/report/report.component';
import { SignupComponent } from './signup/signup.component';
import { ReportAddComponent } from '../app/report-add/report-add.component';
import { QuestionnaireShowComponent } from '../app/questionnaire-show/questionnaire-show.component';

const routes: Routes = [
  { path: '', component: MainComponent },
  { path: 'questionnaire', component: QuestionnaireComponent },
  { path: 'chat', component: ChatComponent },
  { path: 'login', component: LoginComponent },
  { path: 'account', component: AccountComponent },
  { path: 'faq', component: FaqComponent },
  { path: 'report/show', component: ReportComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'report/add', component: ReportAddComponent },
  { path: 'questionnaire/show', component: QuestionnaireShowComponent },
  { path: '**', redirectTo: '' },
];
export const AppRoutingModule: ModuleWithProviders = RouterModule.forRoot(routes);

