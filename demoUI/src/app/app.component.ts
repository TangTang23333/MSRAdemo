import { Component } from '@angular/core';
import { Employee } from './Model/Employee';
import { EmployeeService } from './Service/employee.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'demo';
  clicked: boolean[] = []; 
  employees: Employee[] = []; 
  
  // employees = [
  //   {id:1, name: "Abby", gender: "Female"}, 
  //   {id:2, name: "Belinda", gender: "Female"}, 
  //   {id:3, name: "Cindy", gender: "Female"}, 
  //   {id:4, name: "Daisy", gender: "Female"}
  // ]


  constructor(private employeeService: EmployeeService) {

  
  }

  ngOnInit() {
      this.employeeService.getAllEmployees().subscribe(  res => {

      this.employees = res; 
      this.clicked = new Array(res.length).fill(false);
    })
    
  }

  onClickId(id: number) {

    this.clicked[id] = !this.clicked[id];
  }


}
