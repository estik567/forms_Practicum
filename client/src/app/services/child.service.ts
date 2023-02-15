import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import Child from 'src/Models/child';

@Injectable({
  providedIn: 'root'
})
export class ChildService {

  baseRouteUrl = `${environment.baseUrl}/child`
  constructor(public http:HttpClient) { }
  addFormChild(child:Child)
  {
    return this.http.post<Child>(`${this.baseRouteUrl}`,child);
  }
 
}
