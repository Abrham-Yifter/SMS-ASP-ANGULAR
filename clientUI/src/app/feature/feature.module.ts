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

import { NzButtonModule } from 'ng-zorro-antd/button';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { DepartmentCreateComponent } from './department/department-create/department-create.component';
import { DepartmentEditComponent } from './department/department-edit/department-edit.component';
import { FeatureRoutingModule } from './feature-routing.module';


@NgModule({
  declarations: [
    DepartmentComponent,
    CourseComponent,
    StudentComponent,
    EnrollmentComponent,
    DepartmentItemComponent,
    
    DepartmentDetailsComponent,
         DepartmentCreateComponent,
         DepartmentEditComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    NzButtonModule,
    BrowserAnimationsModule,
    
    ToastrModule.forRoot(),
    FeatureRoutingModule,
  ],
  exports: [
    DepartmentComponent,
    RouterModule,
  ],
  bootstrap: [DepartmentComponent]
})
export class FeatureModule { }
