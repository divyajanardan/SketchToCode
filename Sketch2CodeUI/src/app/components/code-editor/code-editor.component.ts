import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser'

import { CdkDragDrop, moveItemInArray, copyArrayItem } from '@angular/cdk/drag-drop';
import { SketchTocodeService } from 'src/app/services/sketch-tocode.service';

@Component({
  selector: 'app-code-editor',
  templateUrl: './code-editor.component.html',
  styleUrls: ['./code-editor.component.scss']
})

export class CodeEditorComponent implements OnInit {
  htmlString:string= '';
  projectName: string='';


  constructor(private sanitized: DomSanitizer, private projectService: SketchTocodeService) {
  }

  ngOnInit(): void {
  }
  onSavePrject(){
    let args;
    console.log(this.htmlString);
    if(this.htmlString != ""){
      args = { 'projectName': '', 'componentName': '', 'componentHtml': this.htmlString };
      this.projectService.createAngularComponent(args);
    }
  }
}
