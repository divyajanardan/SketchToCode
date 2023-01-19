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


  // createProject(args: any): Observable<any>{
  //   const body=JSON.stringify(args);
  //   const header = {
  //     'Content-Type': 'application-json'
  //   };
  //   const options={
  //     method: 'POST',
  //     headers:new HttpHeaders(header)
  //   };
  //   const url = this.baseUri + '/api/project';
  //   return this.http.post(url, body, options);
  // }

  createProject(args: any){
    const body=JSON.stringify(args);
    // const header = {
    //   'Content-Type': 'application-json'
    // };
    // const options={
    //   method: 'POST',
    //   headers:new HttpHeaders(header)
    // };
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
}
