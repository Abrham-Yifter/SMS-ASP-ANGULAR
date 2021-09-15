import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DepartmentComponent } from './department/department.component';
import { CourseComponent } from './course/course.component';
import { StudentComponent } from './student/student.component';
import { EnrollmentComponent } from './enrollment/enrollment.component';
import { DepartmentItemComponent } from './department/department-item/department-item.component';
import { DepartmentDetailsComponent } from './department/department-details/department-details.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    DepartmentComponent,
    CourseComponent,
    StudentComponent,
    EnrollmentComponent,
    DepartmentItemComponent,
    DepartmentDetailsComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      {path: '', component: DepartmentComponent},
      {path: 'department-list', component: DepartmentComponent},
      {path: 'department-detail/:id', component: DepartmentDetailsComponent},
      {path: 'course-list', component: CourseComponent},
      {path: 'student-list', component: StudentComponent},
      {path: 'enrollment-list', component: EnrollmentComponent},
      {path: '**', redirectTo: '', pathMatch: 'full'},
    ]),
  ],
  exports: [
    DepartmentComponent,
    RouterModule
  ]
})
export class FeatureModule { }
