import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit
 {
  title = 'Assignments';
  assignments:any;
   constructor(private http:HttpClient){}
     ngOnInit(): void {
      this.http.get('https://localhost:5001/api/Assignments').subscribe({
  next: response => this.assignments = response,
  error: error => console.log(error),
  complete: () => console.log('request has completed')
});
  }
}
