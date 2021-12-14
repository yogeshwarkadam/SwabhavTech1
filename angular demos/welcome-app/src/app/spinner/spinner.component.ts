import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-spinner',
  templateUrl: './spinner.component.html',
  styleUrls: ['./spinner.component.css']
})
export class SpinnerComponent implements OnInit {

  imageUrl = "assets/R.gif"
  hideImage = true
  btnText = "show"

  handleToggle(e:any){
    console.log (e.target)
    this.hideImage =! this.hideImage
    if (this.btnText == "show") {
    this.btnText = "hide"
    return
    }
    if(this.btnText == "hide")
      this.btnText= "show"
    
   
    
  }
  constructor() { }

  ngOnInit(): void {
  }

}
