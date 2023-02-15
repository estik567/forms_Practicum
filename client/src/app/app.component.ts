import { Component } from '@angular/core';
import { CurrentUserService } from './services/current-user.service';
import { UserService } from './services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(public ser: CurrentUserService) {

  }
  ngOnInit(): void {
    this.ser.currUser.next(this.ser.getFromStorage())
  }
  title = 'forms';
}
