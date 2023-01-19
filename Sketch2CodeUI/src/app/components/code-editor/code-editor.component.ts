import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser'

import { CdkDragDrop, moveItemInArray, copyArrayItem } from '@angular/cdk/drag-drop';
import { SketchTocodeService } from 'src/app/services/sketch-tocode.service';
import { CodeProvidersService } from '../code-providers.service';

@Component({
  selector: 'app-code-editor',
  templateUrl: './code-editor.component.html',
  styleUrls: ['./code-editor.component.scss']
})

export class CodeEditorComponent implements OnInit {
  htmlString:string= '';
  componentName: string='';
  projectName: string='';
  isShowWebApiController = true;
  isShowAngularComponent = true;
  isShowApiModel = true;
  apiProjName: string ="";
  controllerName: string ="";
  apiProjModelName: string ="";
  modelName: string="";


  constructor(private sanitized: DomSanitizer, private projectService: SketchTocodeService, public codeProvidersService: CodeProvidersService) {
  }

  ngOnInit(): void {
    this.apiProjName = this.codeProvidersService.apiProjName;
    this.projectName = this.codeProvidersService.projName;
    this.apiProjModelName = this.codeProvidersService.apiProjName;
  }
  onSavePrject(){
    let args;
    console.log(this.htmlString);
    if(this.htmlString != ""){
      args = { 'projectName': this.projectName, 'componentName': this.componentName, 'componentHtml': this.htmlString };
      this.projectService.createAngularComponent(args);
      window.alert("Component saved");
    }
  }

  ShowApiController(){  
    this.isShowAngularComponent = !this.isShowAngularComponent; 
    this.isShowWebApiController = !this.isShowWebApiController;
  }
  CreateApiController(){
    let args;
    if(this.controllerName != ""){
      args = { 'projectName': this.apiProjName, 'controllerName': this.controllerName };
      this.projectService.createApiController(args);
      window.alert("Controller saved");
    }
  }

  ShowAngularComponent(){   
    this.isShowAngularComponent = !this.isShowAngularComponent;
  }

  ShowApiModel(){
    this.isShowWebApiController = !this.isShowWebApiController;
    this.isShowApiModel =!this.isShowApiModel;
  }
  CreateModelClass(){
    let args;
    if(this.modelName != ""){
      args = { 'projectName': this.apiProjModelName, 'className': this.modelName };
      this.projectService.createApiModelClass(args);
    }
  }
  DownloadProject(){         
      this.projectService.downloadProject(this.apiProjModelName);
      this.projectService.downloadProject(this.projectName);
    
  }
}
