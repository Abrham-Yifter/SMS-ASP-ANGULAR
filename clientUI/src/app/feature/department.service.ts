import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IDepartment } from '../shared/models/departments';
import { IDto } from '../shared/models/dto';

@Injectable({
  providedIn: 'root'
})

export class DepartmentService {

  baseUrl = 'https://localhost:5001/api/Departments';
  
  formData: IDepartment = {} as IDepartment;

  constructor(private http: HttpClient) { }

  getDepartments(){
    return this.http.get<IDto>(this.baseUrl + '/GetAllDepartments');
  }

  getDepartment(id:number){
    return this.http.get<IDto>(this.baseUrl + '?id=' + id);
  }
  postDepartment(){
    console.log(this.formData);
    return this.http.post(this.baseUrl, this.formData);
  }
  updateDepartment(formDa:IDepartment){
    console.log(this.formData);
    return this.http.put(this.baseUrl, formDa);
  }
  deleteDepartment(id:number){
    return this.http.delete(this.baseUrl+ '?id=' + id)
  }

}
