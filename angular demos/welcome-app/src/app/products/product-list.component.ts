import { Component, OnInit } from "@angular/core";
import { Product } from "./product";
import { ProductService } from "./product.service";

@Component({
    selector: "sw-product-list",
    template: `
            <div>
               
<div class="container">
  <table class="table table-dark table-striped">
    <thead>
      <tr>
        <th>Product Id</th>
        <th>Product Name</th>
      </tr>
    </thead>
    <tbody>
      <tr *ngFor="let product of products">
        <td>{{product.id}}</td>
        <td>{{product.name}}</td>
      </tr>
    </tbody>
  </table>
  <input type="textbox" placeholder="add a product" #prod /><button class="btn btn-danger btn-sm mb-1 ml-1" (click)="addProduct(prod.value)">Add Product</button>
</div>

            </div>
         
            `
})

export class ProductListComponent implements OnInit {
    products: Array<Product> = new Array<Product>()
    addProduct(item:string){
     
      this.products.push({id:this.products.length+1,name:item});
      console.log(this.products);
  }
    constructor(private productService: ProductService) {

    }
    ngOnInit() {
        this.products = this.productService.getProducts()
    }

}