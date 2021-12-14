import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-discount',
  templateUrl: './discount.component.html',
  styleUrls: ['./discount.component.css']
})
export class DiscountComponent implements OnInit {

  spinnerActive = false;
  result:number=0;
  constructor() { }
  calculateDiscount(amount:string,rate:string){
    this.spinnerActive = true;
    setTimeout(() => {
    this.spinnerActive = false;

      this.result = parseInt (amount) * parseInt (rate)/100;

    }, 5000);
  }
 
  

  ngOnInit(): void {
  }

}
