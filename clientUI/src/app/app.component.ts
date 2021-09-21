import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { AccountService } from './account/account.service';
import { IUser } from './shared/models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  isCollapsed = false;
  currentUser$: Observable<IUser>;

  constructor(private accountService: AccountService){}

  ngOnInit() {
    this.currentUser$ = this.accountService.currentUser$;
  }
}
