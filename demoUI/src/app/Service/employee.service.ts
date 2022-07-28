import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../Model/Employee';




@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient ) { }
  url = "https://localhost:7142/employees";

  getAllEmployees(): Observable<Employee[]> {

      return this.http.get<Employee[]>(this.url); 
  }


}
