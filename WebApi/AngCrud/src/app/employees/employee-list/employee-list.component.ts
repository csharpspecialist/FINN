import { Component, OnInit } from '@angular/core';
import {EmployeeService} from '../shared/employee.service'
import { Employee } from '../shared/employee.model';
import {ToastrService} from 'ngx-toastr'

@Component({
  selector: 'employeeList',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor( private employeeService: EmployeeService,private toastr : ToastrService) { }

  ngOnInit() {
    this.employeeService.getEmployeeList(); 
  }

  updateRec(emp: Employee) {
this.employeeService.selEmployee = Object.assign({}, emp);;
  }


delEmp(id: number) {
  if(confirm('Are you sure you want to delete this record??') == true)
  this.employeeService.deleteEmployee(id)
  .subscribe(x => {
    this.employeeService.getEmployeeList(); 
   this.toastr.warning("Deleted Successfully", "Employee Register")
  })

}


}


