import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';


@Component({
  selector: 'sw-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnInit {

  @Input()
  rating:number=1

  @Output()
  ratingClicked:EventEmitter<string>= new EventEmitter<string>()
  constructor() {
    console.log(this.rating,"inside constructor");
   }

  ngOnInit(): void {
    console.log( this.rating,"inside oninit");
  }
  clickHandler(){
    //console.log("click handler");
    this.ratingClicked.emit(`somebody clicked on rating ${this.rating}`)
  }

}
