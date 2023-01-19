import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SketchTocodeService {
  private baseUri:string;
  constructor(private http: HttpClient) { 
    this.baseUri = environment.apiEndPoint;
  }

  createProject(args: any){
    const body=JSON.stringify(args);    
    const httpOptions = {
      method: 'POST',
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Access-Control-Allow-Origin': '*'
      })
    };
    const url = this.baseUri + '/api/project';
    return this.http.post(url, body, httpOptions).toPromise().then(res => {
      console.log(res);
    });
  }

  createAngularComponent(args: any){
    const body=JSON.stringify(args);    
    const httpOptions = {
      method: 'POST',
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Access-Control-Allow-Origin': '*'
      })
    };
    const url = this.baseUri + '/api/project/createangularcomponent';
    return this.http.post(url, body, httpOptions).toPromise().then(res => {
      console.log(res);
    });
  }

  createApiController(args: any){
    const body=JSON.stringify(args);    
    const httpOptions = {
      method: 'POST',
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Access-Control-Allow-Origin': '*'
      })
    };
    const url = this.baseUri + '/api/project/createwebapicontrollers';
    return this.http.post(url, body, httpOptions).toPromise().then(res => {
      console.log(res);
    });
  }

  createApiModelClass(args: any){
    const body=JSON.stringify(args);    
    const httpOptions = {
      method: 'POST',
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Access-Control-Allow-Origin': '*'
      })
    };
    const url = this.baseUri + '/api/project/createwebapimodelclass';
    return this.http.post(url, body, httpOptions).toPromise().then(res => {
      console.log(res);
    });
  }

  downloadProject(projectname: any){
    const body=JSON.stringify(projectname);    
    const httpOptions = {
      method: 'GET',
      headers: new HttpHeaders({
        'Content-Type':  'application/zip',
        'Access-Control-Allow-Origin': '*'
      })
    };
    const url = this.baseUri + `/api/project/downloadproject?projectName=${projectname}`;
    return this.http.get(url, httpOptions).toPromise().then(res => {
      console.log(res);
    });
  }
}
