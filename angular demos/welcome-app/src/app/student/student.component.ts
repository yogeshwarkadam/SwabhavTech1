import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  students = [
    {fName:"yogeshwar kadam",cgpa:8,doj:'23/08/2021'},
    {fName:"vinod tambe",cgpa:7,doj:'23/08/2021'},
    {fName:"shivam sutar",cgpa:6,doj:'23/08/2021'},
    {fName:"ganesh padhi",cgpa:7,doj:'23/08/2021'},
    {fName:"akshay vandhekar",cgpa:8,doj:'23/08/2021'},
    {fName:"ram mali",cgpa:6,doj:'23/08/2021'}
  ];
  codeDisplay = false;
  student = new student("yogeshwar kadam",9,new Date())
  constructor() { }


  ngOnInit(): void {
  }
  displayDiv(){
    this.codeDisplay = true;
  }

}
export class student{
  constructor(public fullName:string,public cgpa:number,public doj:Date){

  }
}
