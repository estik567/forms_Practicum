import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import User from 'src/Models/user';
import { CurrentUserService } from '../services/current-user.service';

@Component({
  selector: 'app-instructions-for-fill',
  templateUrl: './instructions-for-fill.component.html',
  styleUrls: ['./instructions-for-fill.component.scss']
})
export class InstructionsForFillComponent implements OnInit {
myUser:User;
sub:Subscription;

  constructor(public currentUser:CurrentUserService) { }
  ngOnDestroy():void{
    this.sub.unsubscribe();
  }
  ngOnInit(): void {
    this.sub = this.currentUser.currUser.subscribe(succ => {
      this.myUser = succ;
    })
  }

}
