import { Component, OnChanges, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Employee } from '../models/employee';
import { ConnectionDbService } from '../services/connection-db.service';


@Component({
  selector: 'app-form-employee',
  templateUrl: './form-employee.component.html',
  styleUrls: ['./form-employee.component.css']
})
export class FormEmployeeComponent implements OnInit {

  formEmployee!: FormGroup;
  employee?: Employee;
  edit: string = "Save";
  constructor(private readonly fb: FormBuilder, public connectionDbService: ConnectionDbService) { }

  ngOnInit(): void {
    this.formEmployee = this.fb.group({
      Id: [null],
      Name: ['',[Validators.required, Validators.maxLength(25)]],
      LastName: ['',[Validators.required, Validators.maxLength(25)]],
      Phone: ['',[Validators.required, Validators.maxLength(24)]]
    });
    this.connectionDbService.emitEmployee$.forEach(employee => {
      this.formEmployee.patchValue(employee);
      this.edit = "Modify";
    })
  }

  get f() {
    return this.formEmployee.controls;
  }

  saveEmployee(): void {
    if(this.formEmployee.value.Id){
      this.connectionDbService.updateEmployee(this.formEmployee.value).subscribe(res => {
        this.formEmployee.reset();
        console.log("Employee updated");
      });
    }
    else{
        var employee = new Employee();
        employee.Name = this.formEmployee.get('Name')?.value;
        employee.LastName = this.formEmployee.get('LastName')?.value;
        employee.Phone = this.formEmployee.get('Phone')?.value;

        this.connectionDbService.addEmployee(employee).subscribe(res => {
          this.formEmployee.reset();
          console.log("Employee added");
        });
    }
  }

  cleanForm(): void {
    this.formEmployee.reset();
    this.edit = "Save";
  }

}
