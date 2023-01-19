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
      "Name": "Input",
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
      this.controlString += "html"
      this.htmlString = this.sanitized.bypassSecurityTrustHtml(this.controlString);
    }
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

}
