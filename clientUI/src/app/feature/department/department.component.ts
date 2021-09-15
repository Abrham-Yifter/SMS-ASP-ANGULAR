import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IDepartment } from 'src/app/shared/models/departments';
import { DepartmentService } from '../department.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent implements OnInit {

  departments: IDepartment[] = [];

  constructor(public departmentService: DepartmentService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.getDepartments();
  }

  getDepartments(){
    this.departmentService.getDepartments().subscribe(res => {
      this.departments = res.data;
    }, error =>{
      console.log(error);
    });
  }
  
  onSubmit(form:NgForm){
    this.departmentService.postDepartment()
    //.next(()=> {this.getDepartments();})
    .subscribe(resp => {
      this.resetForm(form);
      this.toastr.success('Submitted Successfully', 'New Department Added!!');
      this.getDepartments();
    }, error => {
      console.log(error);
    })
  }
  populateForm(selectedRecord:IDepartment){
    this.departmentService.formData = Object.assign({},selectedRecord);
  }
  resetForm(form:NgForm){
    form.form.reset();
  }

}
