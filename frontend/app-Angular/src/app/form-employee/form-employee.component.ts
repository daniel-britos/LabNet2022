import { Component, OnInit } from '@angular/core';
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

  constructor(private readonly fb: FormBuilder, private connectionDbService: ConnectionDbService) { }

  ngOnInit(): void {
    this.formEmployee = this.fb.group({
      Name: ['', [Validators.required, Validators.maxLength(25)]],
      LastName: ['', [Validators.required, Validators.maxLength(25)]],
      Phone: ['', [Validators.required, Validators.maxLength(24)]]
    });
  }

  onSubmit(): void {
    console.log(this.formEmployee.value);
  }

  get f() {
    return this.formEmployee.controls;
  }

  saveEmployee(): void {
    var employee = new Employee();
    employee.Name = this.formEmployee.get('Name')?.value;
    employee.LastName = this.formEmployee.get('LastName')?.value;
    employee.Phone = this.formEmployee.get('Phone')?.value;

    this.connectionDbService.addEmployee(employee).subscribe(res => {
      this.formEmployee.reset();
      console.log("Employee added");
    });
  }
  cleanForm(): void {
    this.formEmployee.reset();
  }

}
