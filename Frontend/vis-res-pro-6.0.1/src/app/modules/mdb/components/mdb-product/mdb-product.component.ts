// https://developer.mozilla.org/en-US/docs/Web/Events

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'vrs-mdb-product',
  templateUrl: './mdb-product.component.html',
  styleUrls: ['./mdb-product.component.scss']
})
export class MdbProductComponent implements OnInit {

  pageTitle = 'Acme Product Management';

  imageWidth = 50;
  imageMargin = 2;
  showImage = false;
  listFilter = 'cart';   // [(ngModel)] => Banana in a Box

  products: any[] = [
        {
          'productId': 1,
          'productName': 'Leaf Rake',
          'productCode': 'GDN-0011',
          'releaseDate': 'March 19, 2016',
          'description': 'Leaf rake with 48-inch wooden handle.',
          'price': 19.95,
          'starRating': 3.2,
          'imageUrl': 'http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png'
      },
      {
          'productId': 2,
          'productName': 'Garden Cart',
          'productCode': 'GDN-0023',
          'releaseDate': 'March 18, 2016',
          'description': '15 gallon capacity rolling garden cart',
          'price': 32.99,
          'starRating': 4.2,
          'imageUrl': 'http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png'
      },
  ];

  constructor() {

  }

  ngOnInit() {

  }

  // https://developer.mozilla.org/en-US/docs/Web/Events
  toggleImage(): void {
    this.showImage = !this.showImage;
  }

  test() {
    const nicknames = ['di', 'boo', 'punkeye'];
    for (const nickname1 of nicknames) {          // interates over iterable objects, such as an array
      // tslint:disable-next-line:no-console
      console.log(nickname1);                  // => di, boo, punkeye
    }
    // tslint:disable-next-line:forin
    for (const nickname2 in nicknames) {          // iterates over the properties of an object (remember by saying 'in' interates the index)
      // tslint:disable-next-line:no-console
      console.log(nickname2)                   // ==> 0, 1, 2
    }

  }


}
