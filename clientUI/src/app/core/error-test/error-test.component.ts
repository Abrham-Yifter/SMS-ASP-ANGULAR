import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-error-test',
  templateUrl: './error-test.component.html',
  styleUrls: ['./error-test.component.css']
})
export class ErrorTestComponent implements OnInit {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }
  
  get404Error(){
    this.http.get(this.baseUrl + 'Departments/'+ '?id=' + 55).subscribe(res=>{
      console.log(res);
    }, error =>{
      console.log(error);
    });
  }
  get500Error(){
    this.http.get(this.baseUrl + 'buggy/servererror').subscribe(res=>{
      console.log(res);
    }, error =>{
      console.log(error);
    });
  }

  get400Error(){
    this.http.get(this.baseUrl + 'buggy/badrequest').subscribe(res=>{
      console.log(res);
    }, error =>{
      console.log(error);
    });
  }

  get400ValidationError(){
    this.http.get(this.baseUrl + 'Departments/'+ '?id=' + '55').subscribe(res=>{
      console.log(res);
    }, error =>{
      console.log(error);
    });
  }
}
