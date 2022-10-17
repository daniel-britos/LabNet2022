import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConnectionDbService {
  /* https://localhost:44339/api/Employees */
  endpoint: string = 'api/Employees';

  constructor(private http: HttpClient) { }

  public addEmployee(request: Employee): Observable<any> {
    let url = environment.apiEmployee + this.endpoint;
    return this.http.post(url, request);
  }

  public getEmployeesList(): Observable<Array<Employee>> {
    /* Concatenating the apiEmployee and endpoint variables to create a url. */
    let url = environment.apiEmployee + this.endpoint;
    return this.http.get<Array<Employee>>(url);
  }

  public deleteEmployee(id: number): Observable<any> {
    let url = environment.apiEmployee + this.endpoint;
    return this.http.delete(url + "/" + id);
  }
}
