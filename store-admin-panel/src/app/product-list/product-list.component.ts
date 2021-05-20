import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html',
  styles: [`:host{border: 1px solid #000;}`]
})
export class ProductListComponent implements OnInit {
  @Input() products: any[];
  @Output() productAdded = new EventEmitter();
  @Output() productRemoved = new EventEmitter();
  addProductToCart(product) {
    this.productAdded.emit(product);
  }
  removeProductFromCart(product) {
    this.productRemoved.emit(product);
  }

  ngOnInit() {
    console.log(this.products);
  }
}
