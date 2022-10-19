import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { ConnectionDbService } from '../services/connection-db.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-table-employee',
  templateUrl: './table-employee.component.html',
  styleUrls: ['./table-employee.component.css']
})
export class TableEmployeeComponent implements OnInit {

  formEmployee!: FormGroup;
  id!:number;

  //modelEmployee!: Employee
  public employeeList: Array<Employee> = [];
  constructor(private readonly fb: FormBuilder,
              private connectionDbService: ConnectionDbService) { }

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees() {
      this.connectionDbService.getEmployeesList().subscribe(res => {
      this.employeeList = res;
      console.log(this.employeeList);
    })
  }

  deleteEmployee(employee: any){
    if(window.confirm('¿Are you sure?')){
      this.connectionDbService.deleteEmployee(employee.Id).subscribe(res =>{
        this.getEmployees();
      });
    }
  }

  modifyEmployee(employee: Employee) {
    this.connectionDbService.sendEmp(employee);
  };
}

