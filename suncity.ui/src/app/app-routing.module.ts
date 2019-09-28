import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main/main.component';
import { ModuleWithProviders } from '@angular/core';
import { QuestionnaireComponent } from '../app/questionnaire/questionnaire.component';
import { LoginComponent } from './login/login.component';
import { AccountComponent } from './toolbar/account/account.component';
import { ChatComponent } from '../app/chat/chat.component';
import { FaqComponent } from '../app/faq/faq.component';

const routes: Routes = [
  { path: '', component: MainComponent },
  { path: 'questionnaire', component: QuestionnaireComponent },
  { path: 'chat', component: ChatComponent },
  { path: 'login', component: LoginComponent },
  { path: 'account', component: AccountComponent },
  { path: 'faq', component: FaqComponent },
  { path: '**', redirectTo: '' },
];
export const AppRoutingModule: ModuleWithProviders = RouterModule.forRoot(routes);

