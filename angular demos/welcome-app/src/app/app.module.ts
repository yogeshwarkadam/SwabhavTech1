import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { WelcomeComponent } from './welcome.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SpinnerComponent } from './spinner/spinner.component';
import { GreetComponent } from './greet/greet.component';
import { DiscountComponent } from './discount/discount.component';
import { FormsModule } from '@angular/forms';

import { BlueBallComponent } from './blue-ball/blue-ball.component';
import { CircleComponent } from './circle/circle.component';
import { StudentComponent } from './student/student.component';
import { SnakePipe } from './snake.pipe';
import { CgpaToColorPipe } from './cgpa-to-color.pipe';
import { ProductItemComponent } from './products/product-item.component';
import { LoopingComponent } from './looping/looping.component';
import { ProductListComponent } from './products/product-list.component';
import { ProductService } from './products/product.service';
import { StarComponent } from './star/star.component';
import { GalleryComponent } from './gallery/gallery.component';
import { GalleryHomeComponent } from './gallery-home/gallery-home.component';



@NgModule({
  declarations: [
    WelcomeComponent,
    HeaderComponent,
    FooterComponent,
    SpinnerComponent,
    GreetComponent,
    DiscountComponent,
    LoopingComponent,
    BlueBallComponent,
    CircleComponent,
    StudentComponent,
    SnakePipe,
    CgpaToColorPipe,
    ProductItemComponent,
    ProductListComponent,
    StarComponent,
    GalleryComponent,
    GalleryHomeComponent
   
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [ProductService],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
