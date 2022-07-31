import {Component} from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { Employee } from './Model/Employee';
import { MatTableDataSource } from '@angular/material/table';
import { EmployeeService } from './Service/employee';

/**
 * @title Table with expandable rows
 */
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class AppComponent  {
  columnsToDisplay = ['id', 'name', 'gender'];
  columnsToDisplayWithExpand = [...this.columnsToDisplay, 'expand'];
  expandedElement: Employee | null;
  employees : Employee[] = [];  
  filterSource = new MatTableDataSource(ELEMENT_DATA);


  constructor(private service : EmployeeService) {

  }

  ngOnInit() {
      this.service.getAllEmployees().subscribe(  

        res => {
          this.employees = res; 
          console.log(res); 
          this.filterSource = new MatTableDataSource(res);
        }
      );

  }



  

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.filterSource.filter = filterValue.trim().toLowerCase();
  }
}





const ELEMENT_DATA: Employee[] = [
      {id:1, name: "Abby", gender: "Female", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}, 
      {id:2, name: "Belinda", gender: "Female", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}, 
      {id:3, name: "Cindy", gender: "Female", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}, 
      {id:4, name: "Daisy", gender: "Female", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'},
      {id:5, name: "Emma", gender: "Female", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}, 
      {id:6, name: "Fred", gender: "Male", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'},
      {id:7, name: "Greg", gender: "Male", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}, 
      {id:8, name: "Helen", gender: "Female", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'},
      {id:9, name: "Iain", gender: "Male", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}, 
      {id:10, name: "Jack", gender: "Male", phone: '1234567890', email: '123@gamil.com', address: '1000 jackson avenue, SF, CA'}
    ];



