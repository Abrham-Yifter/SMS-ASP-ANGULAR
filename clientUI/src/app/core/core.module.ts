import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { RouterModule } from '@angular/router';
import { ErrorTestComponent } from './error-test/error-test.component';
import { ToastrModule } from 'ngx-toastr';



@NgModule({
  declarations: [NavBarComponent, ErrorTestComponent],
  imports: [
    CommonModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      {path: 'error-test', component: ErrorTestComponent},
    ]),
  ],
  exports: [NavBarComponent]
})
export class CoreModule { }
