import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser'

import { CdkDragDrop, moveItemInArray, copyArrayItem } from '@angular/cdk/drag-drop';
@Component({
  selector: 'app-input-elements',
  templateUrl: './input-elements.component.html',
  styleUrls: ['./input-elements.component.scss']
})
export class InputElementsComponent implements OnInit {

  constructor(private sanitized: DomSanitizer) {
  }

  ngOnInit(): void {
  }
  dragTextA(test: any){    
    test.dataTransfer.setData('text/html', '<textarea id="w3review" name="w3review" rows="4" cols="50" placeholder="Textarea"></textarea>');    
  }
  dragText(test:any){
    test.dataTransfer.setData('text/html', '<input type="text" id="lname" name="lname">')
  }
  dragButton(test:any){
    test.dataTransfer.setData('text/html', '<input type="submit" value="Submit">')
  }

  
}
