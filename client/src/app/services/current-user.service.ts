import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import User from 'src/Models/user';

@Injectable({
  providedIn: 'root'
})
export class CurrentUserService {
  currUser=new BehaviorSubject<User>(null);
  saveInStorage(user) {
    localStorage.setItem("currentUser", JSON.stringify(user));
  }
  getFromStorage() {
    let u = localStorage.getItem("currentUser");
    if (!u)
      return null;
    return JSON.parse(u);
  }
  removeFromStorage() {
    localStorage.removeItem("currentUser");
  }
  constructor() { }
}
