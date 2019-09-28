import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Role } from '../models/role';
import { MatOptionSelectionChange } from '@angular/material/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { RegisterDto } from '../models/registerDto';
import { JwtService } from '../services/jwt.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {
  form: FormGroup;
  roles = [
    { value: Role.User, viewValue: 'Пользователь' },
    { value: Role.Curator, viewValue: 'Куратор' },
    { value: Role.Mentor, viewValue: 'Наставник' },
    { value: Role.Psychologist, viewValue: 'Психолог' }
  ];

  constructor(
    private fb: FormBuilder,
    private snackBar: MatSnackBar,
    private jwtService: JwtService,
    private router: Router
  ) {
    this.createForm();
  }

  ngOnInit() {
  }

  onRoleChange(event: MatOptionSelectionChange) {
    const value = event.source.value;
  }

  private createForm() {
    this.form = this.fb.group({
      email: [null, [Validators.email]],
      firstName: [null, [Validators.required]],
      lastName: null,
      role: [null, [Validators.required]],
      password: [null, [Validators.required]],
      confirmPassword: [null, [Validators.required]]
    });
  }

  signup() {
    if (!this.form.valid) {
      this.showMessage('Некорректный ввод...');
    }
    const payload: RegisterDto = {
      confirmPassword: this.form.controls.confirmPassword.value,
      email: this.form.controls.email.value,
      firstName: this.form.controls.firstName.value,
      lastName: this.form.controls.lastName.value,
      password: this.form.controls.password.value
    };

    this.jwtService.register(payload).subscribe(r => {
      this.showMessage("Успешно");
      this.router.navigate(['/login']);
    });
  }

  showMessage(message: string, duration = 1500) {
    this.snackBar.open(message, null, {
      duration: duration
    });
  }

}
