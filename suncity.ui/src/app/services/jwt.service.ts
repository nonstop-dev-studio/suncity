import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';
import { tap } from 'rxjs/operators';
import { LoginDto } from '../models/loginDto';
import { RegisterDto } from '../models/registerDto';
import { Observable, throwError } from 'rxjs';
import {Questionnaire} from "src/app/models/questionnaire";
import { of } from 'rxjs';
import { Router } from '@angular/router';
import { Report } from '../models/report';
@Injectable({
    providedIn: 'root'
})
export class JwtService {
    constructor(private httpClient: HttpClient, private router: Router) { }

    login(loginDto: LoginDto) {
        const payload = {
            email: loginDto.email,
            password: loginDto.password
        };
        return this.httpClient
            .post(
                environment.authRequest, payload)
            .pipe(tap((res: any) => {
                localStorage.setItem('token', res.token);
                console.log('Getting user info...');
                this.getUserInfo();
            }));
    }

    getUserInfo() {
        return this.httpClient.get(environment.getUser).pipe(tap(res => console.log('user: ' + res)));
    }

    register(data: RegisterDto) {
        return this.httpClient.post(environment.register, data).pipe(tap(res => {
            console.log('register res: ' + res);
        }));
    }

    logout() {
        localStorage.removeItem('token');
        this.router.navigate(['']);
        return of(null);
    }

    public get loggedIn(): boolean {
        console.log('QQQ');
        return localStorage.getItem('token') !== null;
    }
    postQuestionnaire(questionnaire: Questionnaire) {
         return this.httpClient.post(environment.postQuestionnaire,(questionnaire));
    }
    postReport(report: Report) {
        return this.httpClient.post(environment.postReport,(report));
   }
   getReport(): Observable<Report[]> {
       return <Observable<Report[]>>
    this.httpClient.get(environment.getReport);
    }
    getQuestionnaire(): Observable<Questionnaire[]> {
        return <Observable<Questionnaire[]>>
     this.httpClient.get(environment.getQuestionnaire);
 }
}