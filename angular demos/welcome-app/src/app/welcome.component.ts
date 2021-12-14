import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'sw-welcome-root',
	templateUrl: './welcome.component.html',

})
export class WelcomeComponent implements OnInit {
	message: string
	today: string
	randomValue:number
	constructor() {
		console.log("constructor created");
		this.message = "welcome to swabhav tech";
		this.today = new Date().toString()
		this.randomValue =  Math.random()
	}
	handleRatingClicked(e:string){
		console.log(e)
		console.log(e.toUpperCase());
		this.message=e.toUpperCase();
	}

	ngOnInit(){
		console.log("component and view loaded successfully");
		setTimeout(()=>{
			this.message = "welcome to data binding after 3 seconds"
			this.today = new Date().toString()
		},3000)
	}
}
function toUpperCase(): any {
	throw new Error('Function not implemented.');
}

