import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { MaterialModule } from './common/material.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { QuestionnaireComponent } from './questionnaire/questionnaire.component';
import { ChatComponent } from './chat/chat.component';
import { FaqComponent } from './faq/faq.component';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { JwtService } from './services/jwt.service';
import { AccountComponent } from './toolbar/account/account.component';
import { ReportComponent } from './report/report.component';
import { SignupComponent } from './signup/signup.component';
import { ReportAddComponent } from './report-add/report-add.component';
import { QuestionnaireShowComponent } from './questionnaire-show/questionnaire-show.component';
import { AboutChatComponent } from './about-chat/about-chat.component';
import { ChatWithPsychologistComponent } from './chat-with-psychologist/chat-with-psychologist.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    ToolbarComponent,
    LoginComponent,
    AccountComponent,
    QuestionnaireComponent,
    LoginComponent,
    ChatComponent,
    FaqComponent,
    ReportComponent,
    SignupComponent,
    ReportAddComponent,
    QuestionnaireShowComponent,
    AboutChatComponent,
    ChatWithPsychologistComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MaterialModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [JwtService],
  bootstrap: [AppComponent]
})
export class AppModule { }
