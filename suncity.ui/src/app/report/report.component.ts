import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { Subscription } from 'rxjs';
import { JwtService } from 'src/app/services/jwt.service';
import { Router } from '@angular/router';
import { Report } from 'src/app/models/report';
import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';
@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.scss']
})
export class ReportComponent implements OnInit, OnDestroy {
  report: Report[];
  sub: Subscription;
  constructor(
    protected jwtService: JwtService,
    protected cdr: ChangeDetectorRef,
    protected router: Router
  ) { }

  ngOnInit() {
    this.sub = new Subscription();
    this.getData();
  }
  private getData(){
    this.sub.add(
      this.jwtService.getReport().subscribe((r: Report[])=>{
        this.report = r;
        for(var element in this.report){
          console.log(element);
        } 
        this.cdr.markForCheck();
      })
    );
  }
  ngOnDestroy(){
    this.sub.unsubscribe();
  }
}
