import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { DepartmentService } from '../../department.service';
import { NgForm } from '@angular/forms';
import { IDepartment } from 'src/app/shared/models/departments';

@Component({
  selector: 'app-department-edit',
  templateUrl: './department-edit.component.html',
  styleUrls: ['./department-edit.component.css']
})
export class DepartmentEditComponent implements OnInit {

  department = {} as IDepartment[];
  dept = <IDepartment>{}
  
  constructor(public departmentService: DepartmentService, 
    private toastr: ToastrService,
    private activateRoute: ActivatedRoute,
    private router: Router) { }
    
    ngOnInit(): void {
      this.loadDepartment();
    }
    
    loadDepartment(){
      this.departmentService.getDepartment(+this.activateRoute.snapshot.paramMap.get('id')).subscribe(res => {
        this.department = res.data;
        this.dept = this.department[0];
        //console.log(this.dept);
      }, error =>{
        console.log(error);
      });
  
    }

  onSubmit(form:NgForm){
    this.departmentService.updateDepartment(form.form.value)
    .subscribe(resp => {
      this.toastr.info('Updated Successfully', 'Department Updated!!');
      this.router.navigateByUrl('department-list');
    }, error => {
      console.log(error);
    })
  }
}
