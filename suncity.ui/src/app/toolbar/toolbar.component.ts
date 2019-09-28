import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { JwtService } from '../services/jwt.service';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {
  isLoggedIn;

  constructor(private router: Router, private jwtService: JwtService) { }

  ngOnInit() {
    this.isLoggedIn = this.jwtService.loggedIn;
  }

  login() {
    this.router.navigateByUrl('/login');
  }

  account() {
    this.router.navigateByUrl('/account');
  }
}
