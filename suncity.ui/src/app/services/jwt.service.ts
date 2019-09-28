import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';
import { tap } from 'rxjs/operators';
import {Questionnaire} from "src/app/models/questionnaire";
@Injectable({
    providedIn: 'root'
})
export class JwtService {
    constructor(private httpClient: HttpClient) { }

    login(username: string, password: string) {
        return this.httpClient
            .post(
                environment.authRequest, { username, password }, {responseType: 'text'})
            .pipe(tap((res: string) => localStorage.setItem('access_token', res)))
    }

    register(email: string, password: string) {
        return this.httpClient.post<{ access_token: string }>('http://www.your-server.com/auth/register', { email, password }).pipe(tap(res => {
            this.login(email, password)
        }))
    }

    logout() {
        localStorage.removeItem('access_token');
    }

    public get loggedIn(): boolean {
        console.log('QQQ');
        return localStorage.getItem('access_token') !== null;
    }
    postQuestionnaire(questionnaire: Questionnaire) {
         return this.httpClient.post(environment.postQuestionnaire,(questionnaire));
    }
}