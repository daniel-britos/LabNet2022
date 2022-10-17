import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { ConnectionDbService } from '../services/connection-db.service';

@Component({
  selector: 'app-table-employee',
  templateUrl: './table-employee.component.html',
  styleUrls: ['./table-employee.component.css']
})
export class TableEmployeeComponent implements OnInit {

  public employeeList: Array<Employee> = [];
  constructor(private connectionDbService: ConnectionDbService) { }

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees() {
      this.connectionDbService.getEmployeesList().subscribe(res => {
      this.employeeList = res;
      console.log(this.employeeList);
    })
  }
}
