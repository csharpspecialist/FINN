import { Injectable } from '@angular/core';
import { Employee} from './employee.model';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';

import {Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';



@Injectable()
export class EmployeeService {

selEmployee: Employee;
employeeList: Employee [];

  constructor(private http: Http) { }
//creates new employees
postEmployee(emp : Employee) {
  var body = JSON.stringify(emp);
  var headerOptions = new Headers({'Content-Type': 'application/json'});
var requestOptions = new RequestOptions({method:RequestMethod.Post,headers: headerOptions});

 return this.http.post('http://localhost:54757/api/Employees', body,requestOptions).map(x => x.json());
}


putEmployee(id,emp) {
  var body = JSON.stringify(emp);
  var headerOptions = new Headers({'Content-Type': 'application/json'});
var requestOptions = new RequestOptions({method:RequestMethod.Put,headers: headerOptions});

 return this.http.put('http://localhost:54757/api/Employees/'+ id, body,requestOptions).map(res => res.json());
}


getEmployeeList(){
  this.http.get('http://localhost:54757/api/Employees')
  .map((data: Response) =>{
    return data.json() as Employee[];
  } ).toPromise().then(x => {
    this.employeeList = x;
  })
}

deleteEmployee(id:number){
  return this.http.delete('http://localhost:54757/api/Employees/'+ id ).map(res => res.json());

}

}