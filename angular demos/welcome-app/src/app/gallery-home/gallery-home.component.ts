import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-gallery-home',
  templateUrl: './gallery-home.component.html',
  styleUrls: ['./gallery-home.component.css']
})
export class GalleryHomeComponent implements OnInit {
  baseURL:string='https://source.unsplash.com/random/160x160?'
  random_images = [
    'sig=1', 
    'sig=2',
    'sig=3',
    'sig=4', 
    'sig=5',
    'sig=6',
    
]

  constructor() { }

  ngOnInit(): void {
  }

}
