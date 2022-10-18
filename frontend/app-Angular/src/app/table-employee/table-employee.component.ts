import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee';
import { ConnectionDbService } from '../services/connection-db.service';

@Component({
  selector: 'app-table-employee',
  templateUrl: './table-employee.component.html',
  styleUrls: ['./table-employee.component.css']
})
export class TableEmployeeComponent implements OnInit {

  modelEmployee!: Employee
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

  deleteEmployee(employee: any){
    if(window.confirm('¿Are you sure?')){
      this.connectionDbService.deleteEmployee(employee.Id).subscribe(res =>{
        this.getEmployees();
      });
    }
  }

  updateEmployee(request: Employee) {
    console.log("Valor del request: " + request);
    this.modelEmployee.Id = request.Id;
    this.modelEmployee.Name = request.Name;
    this.modelEmployee.LastName = request.LastName;
    this.modelEmployee.Phone = request.Phone;
    this.connectionDbService.updateEmployee(request);
  }
}

