import { Component, Input, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { IDepartment } from 'src/app/shared/models/departments';
import { DepartmentService } from '../../department.service';

@Component({
  selector: 'app-department-item',
  templateUrl: './department-item.component.html',
  styleUrls: ['./department-item.component.css']
})
export class DepartmentItemComponent implements OnInit {
  @Input()
  department!: IDepartment;
  departments: IDepartment[] = [];

  constructor(private departmentService: DepartmentService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }



  onDelete(id:number){
    this.departmentService.deleteDepartment(id)
    .subscribe(res=>{
      this.toastr.error('Department Deleted!', 'The Department has been successfully Deleted!!!');
    }, error =>{
      console.log(error);
    });
  }
}
