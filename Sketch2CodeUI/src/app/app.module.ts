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
import { HomePageComponent } from './components/home-page/home-page.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { ProjectCreationHomeComponent } from './components/project-creation-home/project-creation-home.component';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { FormsModule} from '@angular/forms'; 
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    InputElementsComponent,
    CodeEditorComponent,
    HomePageComponent,
    SideMenuComponent,
    ProjectCreationHomeComponent
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
    DragDropModule,
    MatCheckboxModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
