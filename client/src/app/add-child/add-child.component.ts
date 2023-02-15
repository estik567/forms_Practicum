import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import Child from 'src/Models/child';
import User from 'src/Models/user';
import { ChildService } from '../services/child.service';
import { CurrentUserService } from '../services/current-user.service';

@Component({
  selector: 'app-add-child',
  templateUrl: './add-child.component.html',
  styleUrls: ['./add-child.component.scss']
})
export class AddChildComponent implements OnInit {
  emptyChild: Child = new Child(null, null, null, null);
  myUser: User;
  sub: Subscription;
  constructor(public action: Router, public childService: ChildService, public currentUser: CurrentUserService) { }


  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
  ngOnInit(): void {
    this.sub = this.currentUser.currUser.subscribe(succ => {
      console.log(succ);
      
      this.myUser = succ;

    })
  }
  logOut() {
    this.currentUser.removeFromStorage()
    this.currentUser.currUser.next(null);
  }
  back() {
    this.action.navigate(["add-user"]);
  }
  save() {
    this.emptyChild.parentTz=this.myUser.tz;
    this.childService.addFormChild(this.emptyChild).subscribe((succ) => {
      console.log(succ);

    },
      (err) => {
        alert("התרחשה שגיאה בקבלת הנתונים");
        console.log(err)
      })
    this.emptyChild = new Child(null, null, null, null);
  }
 

}
