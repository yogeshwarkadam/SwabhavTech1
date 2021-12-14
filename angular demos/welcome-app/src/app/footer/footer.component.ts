import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {


  footerMessage:string
  constructor() {
    this.footerMessage = "copyright \u00A9"+ new Date().getFullYear()
   }

  ngOnInit(): void {
  }

}
