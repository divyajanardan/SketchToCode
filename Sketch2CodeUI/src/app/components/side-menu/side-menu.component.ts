import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss']
})
export class SideMenuComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  OpenHome(){
    this.router.navigate(['']);
  }
  OpenCreateProject(){
    //this.router.navigate(['/editor']);
    this.router.navigate(['/createproject']);
  }

}
