import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

import { DepartmentComponent } from './department/department.component';
import { CourseComponent } from './course/course.component';
import { DepartmentCreateComponent } from './department/department-create/department-create.component';
import { DepartmentEditComponent } from './department/department-edit/department-edit.component';
import { DepartmentDetailsComponent } from './department/department-details/department-details.component';
import { StudentComponent } from './student/student.component';
import { EnrollmentComponent } from './enrollment/enrollment.component';

const routes: Routes = [
  {path: '', component: DepartmentComponent},
  {path: 'department-list', component: DepartmentComponent},
  {path: 'department-create', component: DepartmentCreateComponent},
  {path: 'department-edit/:id', component: DepartmentEditComponent},
  {path: 'department-detail/:id', component: DepartmentDetailsComponent},
  {path: 'course-list', component: CourseComponent},
  {path: 'student-list', component: StudentComponent},
  {path: 'enrollment-list', component: EnrollmentComponent},
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class FeatureRoutingModule { }
