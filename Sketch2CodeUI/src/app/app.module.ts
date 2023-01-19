import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {DragDropModule} from '@angular/cdk/drag-drop';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { InputElementsComponent } from './components/input-elements/input-elements.component';
import { CodeEditorComponent } from './components/code-editor/code-editor.component';



@NgModule({
  declarations: [
    AppComponent,
    InputElementsComponent,
    CodeEditorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatButtonModule,
    BrowserAnimationsModule,
    DragDropModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
