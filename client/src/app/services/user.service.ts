import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import User from 'src/Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  baseRouteUrl = `${environment.baseUrl}/user`
  constructor(public http: HttpClient) { }
  addFormUser(user: User) {
    console.log("sssss");

    return this.http.post<User>(`${this.baseRouteUrl}`, user);
  }
}
