import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'sw-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {

  @Input('images') random_images: string[] | undefined;
  @Input('baseURL') baseURL: string = '';

  selectedImage: string = '';
  constructor() { }

  ngOnInit(): void {
  }

  onClickImage(img: string){
    this.selectedImage = this.baseURL + img;
  }
  clearButton(){
    this.random_images = [];
    this.selectedImage = "";
  }

}
