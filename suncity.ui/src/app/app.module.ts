import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
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

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    ToolbarComponent,
    QuestionnaireComponent,
    LoginComponent
    ChatComponent,
    FaqComponent
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
