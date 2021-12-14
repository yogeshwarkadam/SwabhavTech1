import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-blue-ball',
  templateUrl: './blue-ball.component.html',
  styleUrls: ['./blue-ball.component.css']
})
export class BlueBallComponent implements OnInit {
  slideValue=20;
  startedGame = false;
  constructor() { }

  ngOnInit(): void {
  }

  startGame(){
    this.startedGame= true
  }
}
