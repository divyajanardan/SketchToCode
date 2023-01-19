import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser'

import { CdkDragDrop, moveItemInArray, copyArrayItem } from '@angular/cdk/drag-drop';

@Component({
  selector: 'app-code-editor',
  templateUrl: './code-editor.component.html',
  styleUrls: ['./code-editor.component.scss']
})
export class CodeEditorComponent implements OnInit {

  constructor(private sanitized: DomSanitizer) {
  }

  ngOnInit(): void {
  }
  title = 'Sketch2CodeUI';
  public htmlString: any;
  private controlString = "";
  MoviesList : string[] =[
    'Text-Area',
    'Text Box',
    'Button',
    
  ];
  
  public showControl: boolean = false;

  test: Array<any> = [
    {
      "Name": "Text-Area",
      "type": 1
    },
    {
      "Name": "Text Box",
      "type": 2
    },
    {
      "Name": "Button",
      "type": 3
    }
  ];

  MoviesWatched :string[]= [
  ];
  Name:string[]=[];
  onDrop(event: CdkDragDrop<string[]>) {
    this.showControl = true;
    let selectedItem = event.previousContainer.data[event.previousIndex];
    let seelctedControl = this.test.find(t => t.Name === selectedItem);
    if (seelctedControl.type == 1) {
      this.controlString += "<div><input type='text' id='Name' name='Name'></div>"
      //this.htmlString = this.sanitized.bypassSecurityTrustHtml(this.controlString);
    }
    else if (seelctedControl.type == 2) {
      this.controlString += "<div><input type='textbox' id='Name' name='Name'></div>"
      //this.htmlString = this.sanitized.bypassSecurityTrustHtml(this.controlString);
    }
    else if(seelctedControl.type==3){
      this.controlString +="<div><input type='button' id='submit' name='Submit' onClick='SubmitForm()'></div>"
    }
    console.log(this.controlString)
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      copyArrayItem(
        event.previousContainer.data,
        event.container.data,
        event.previousIndex,
        event.currentIndex
      );
    }
    this.Name.push(this.MoviesList[event.currentIndex]);
  }

  public CreateProject()
  {
    console.log(this.controlString);
  }

}
