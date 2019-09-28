import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { JwtService } from '../services/jwt.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {
  get isLoggedIn() {
    return localStorage.getItem('token') !== null;
  }

  constructor(private router: Router, private jwtService: JwtService) { }

  ngOnInit() {
    
  }

  login() {
    this.router.navigateByUrl('/login');
  }

  account() {
    this.router.navigateByUrl('/account');
  }
}
