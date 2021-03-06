import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { slideInOutAnimation } from '../shared/animations';
import { ProductService, PubSubService } from '../core/services';

@Component({
    moduleId: module.id.toString(),
    templateUrl: 'product-add-edit.component.html',
    animations: [slideInOutAnimation],
})

export class ProductAddEditComponent implements OnInit {
    title = 'Add Product';
    product: any = {};

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private productService: ProductService,
        private pubSubService: PubSubService) { }

    ngOnInit() {
        const productId = Number(this.route.snapshot.params['id']);
        if (productId) {
            this.title = 'Edit Product';
            this.product = this.productService.getById(productId);
        }
    }

    saveProduct() {
        // save product
        this.productService.save(this.product);

        // redirect to users view
        this.router.navigate(['products']);

        // publish event so list controller can refresh
        this.pubSubService.publish('products-updated');
    }
}
