import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';
import { tap } from 'rxjs/operators';
import { LoginDto } from '../models/loginDto';
import { RegisterDto } from '../models/registerDto';

@Injectable({
    providedIn: 'root'
})
export class JwtService {
    constructor(private httpClient: HttpClient) { }

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
            }));
    }

    register(data: RegisterDto) {
        return this.httpClient.post(environment.register, data).pipe(tap(res => {
            console.log('register res: ' + res);
        }));
    }

    logout() {
        localStorage.removeItem('token');
    }

    public get loggedIn(): boolean {
        console.log('QQQ');
        return localStorage.getItem('token') !== null;
    }
}