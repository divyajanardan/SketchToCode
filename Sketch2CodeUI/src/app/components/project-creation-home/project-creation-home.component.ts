import { Component, OnInit } from '@angular/core';
import { SketchTocodeService } from 'src/app/services/sketch-tocode.service';

@Component({
  selector: 'app-project-creation-home',
  templateUrl: './project-creation-home.component.html',
  styleUrls: ['./project-creation-home.component.scss']
})
export class ProjectCreationHomeComponent implements OnInit {

  constructor(private projectService: SketchTocodeService) { }

  isShowAngular = true; 
  isWebApi = true;
  angularProjName: string = "";
  apiProjName: string = "";
  createAngular = false;
  createWebApi = false;

  ngOnInit(): void {
  }

  OpenAngularSection(){
    this.createAngular = true;
    this.isShowAngular = !this.isShowAngular;
  }

  OpenWebApiSection(){
    this.createWebApi = true;
    this.isWebApi = !this.isWebApi;
  }

  CreateProject(){
    let args;
    if(this.createAngular){
      args = { 'projectName': this.angularProjName, 'projectType': '2' };
      this.projectService.createProject(args);
    }
    if(this.createWebApi){
      args = { 'projectName': this.apiProjName, 'projectType': '1' };
      this.projectService.createProject(args);
    }    
  }
}
