import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './components/home-page/home-page.component';
import { CodeEditorComponent } from '../app/components/code-editor/code-editor.component';
import { ProjectCreationHomeComponent } from '../app/components/project-creation-home/project-creation-home.component';

const routes: Routes = [
  { path:'', component: HomePageComponent },
  { path:'editor', component: CodeEditorComponent },
  { path:'createproject', component: ProjectCreationHomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
