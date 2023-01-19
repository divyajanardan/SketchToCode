import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
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
    const header = {
      'Content-Type': 'application-json'
    };
    const options={
      method: 'POST',
      headers:new HttpHeaders(header)
    };
    const url = this.baseUri + '/api/project';
    return this.http.post(url, body, options);
  }
}
