import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IDepartment } from 'src/app/shared/models/departments';
import { IDto } from 'src/app/shared/models/dto';
import { DepartmentService } from '../../department.service';

@Component({
  selector: 'app-department-details',
  templateUrl: './department-details.component.html',
  styleUrls: ['./department-details.component.css']
})
export class DepartmentDetailsComponent implements OnInit {
  
  department: IDepartment[] = [];

  constructor(private departmentService: DepartmentService, private activateRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadDepartment();
  }
  
  loadDepartment(){

    this.departmentService.getDepartment(+this.activateRoute.snapshot.paramMap.get('id')).subscribe(res => {
      this.department = res.data;
      console.log(this.department);
    }, error =>{
      console.log(error);
    });

  }
}
