import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Subject } from 'rxjs/internal/Subject'
@Injectable({
  providedIn: 'root'
})
export class ConnectionDbService {
  /* https://localhost:44339/api/Employees */
  endpoint: string = 'api/Employees';
  url: string = environment.apiEmployee + this.endpoint;
  emitEmployee = new Subject<Employee>();
  emitEmployee$ = this.emitEmployee.asObservable();

  constructor(private http: HttpClient) { }

  public sendEmp(employee: Employee){
    this.emitEmployee.next(employee);
  }



  public addEmployee(request: Employee): Observable<any> {
    let url = environment.apiEmployee + this.endpoint;
    return this.http.post(url, request);
  }

  public getEmployeesList(): Observable<Array<Employee>> {
    return this.http.get<Array<Employee>>(this.url);
  }

  public deleteEmployee(id: number): Observable<any> {
    return this.http.delete(this.url + "/" + id);
  }

  public updateEmployee(employee: Employee): Observable<any> {
    return this.http.put(this.url, employee);
  }
}
