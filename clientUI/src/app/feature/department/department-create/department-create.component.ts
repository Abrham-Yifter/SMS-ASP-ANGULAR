import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { DepartmentService } from '../../department.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  selector: 'app-department-create',
  templateUrl: './department-create.component.html',
  styleUrls: ['./department-create.component.css']
})
export class DepartmentCreateComponent implements OnInit {

  constructor(public departmentService: DepartmentService, 
    private toastr: ToastrService,
    private router: Router) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    this.departmentService.postDepartment()
    .subscribe(resp => {
      this.toastr.success('Submitted Successfully', 'New Department Added!!');
      this.router.navigateByUrl('department-list');
    }, error => {
      console.log(error);
    })
  }
}
