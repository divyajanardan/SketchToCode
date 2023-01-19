import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser'

import { CdkDragDrop, moveItemInArray, copyArrayItem } from '@angular/cdk/drag-drop';

@Component({
  selector: 'app-code-editor',
  templateUrl: './code-editor.component.html',
  styleUrls: ['./code-editor.component.scss']
})

export class CodeEditorComponent implements OnInit {
  htmlString:string= '';
  projectName: string='';


  constructor(private sanitized: DomSanitizer) {
  }

  ngOnInit(): void {
  }
  onSavePrject(){
    console.log(this.htmlString);
  }
}
