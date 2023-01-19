import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser'

import { CdkDragDrop, moveItemInArray, copyArrayItem } from '@angular/cdk/drag-drop';

@Component({
  selector: 'app-code-editor',
  templateUrl: './code-editor.component.html',
  styleUrls: ['./code-editor.component.scss']
})

export class CodeEditorComponent implements OnInit {
  htmlString:string= 'drag here'


  constructor(private sanitized: DomSanitizer) {
  }

  ngOnInit(): void {
  }

  onDragStart(test: any) {    
    test.dataTransfer.setData('text/html', '<textarea id="w3review" name="w3review" rows="4" cols="50" placeholder="Textarea"></textarea>>');    
  }
  

}
