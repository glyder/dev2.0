import { Injectable } from '@angular/core';

@Injectable()
export class ProductService {

    constructor() { }

    getAll() {
        return this.getProducts();
    }

    getById(id: number) {
        return this.getProducts().find(product => product.id === id);
    }

    save(product: any) {
        const products = this.getProducts();

        if (product.id) {
            // update existing product

            for (let i = 0; i < products.length; i++) {
                if (products[i].id === product.id) {
                    products[i] = product;
                    break;
                }
            }
            this.setProducts(products);
        } else {
            // create new product

            // assign id
            const lastProduct = products[products.length - 1] || { id: 0 };
            product.id = lastProduct.id + 1;

            // save to local storage
            products.push(product);
            this.setProducts(products);
        }
    }

    delete(id: number) {
        const products = this.getProducts();
        for (let i = 0; i < products.length; i++) {
            const product = products[i];
            if (product.id === id) {
                products.splice(i, 1);
                break;
            }
        }
        this.setProducts(products);
    }

    // private helper methods

    private getProducts(): any[] {
        if (!localStorage.getItem('products')) {
            localStorage.setItem('products', JSON.stringify([]));
        }

        return JSON.parse(localStorage.getItem('products'));
    }

    private setProducts(products: any[]) {
        localStorage.setItem('products', JSON.stringify(products));
    }
}
