import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import User from 'src/Models/user';
import { CurrentUserService } from '../services/current-user.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit {
  empty: User = new User(null, null, null, null, null, null);
  constructor(public action: Router, public userService: UserService,public currentUser:CurrentUserService) { }
  sub: Subscription;
  
  
  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }


  ngOnInit(): void {
    this.sub = this.currentUser.currUser.subscribe(succ => {
      console.log(succ);
      if(succ!=null)
      this.empty = succ;

    })
  }
  save() {
   
    this.userService.addFormUser(this.empty).subscribe((succ) => {
      console.log(succ);

    },
      (err) => {
        alert("התרחשה שגיאה בקבלת הנתונים");
        console.log(err)
      })
    this.empty = new User(null, null, null, null, null, null);
    this.currentUser.removeFromStorage()
    this.currentUser.currUser.next(null);
  }

  addchild(tz:string) {
    this.currentUser.saveInStorage(this.empty);
    this.currentUser.currUser.next(this.empty);
    if(tz===null)
    alert("you didn't fill your tz")
    else
    this.action.navigate(["add-child"])
    
  }


}
