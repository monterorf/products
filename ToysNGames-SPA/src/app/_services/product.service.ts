import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../_models/product';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
baseUrl = 'http://localhost:5000/api/products/'
products: Product[];

constructor(private http: HttpClient) { }

getProducts() {
  return this.http.get<Product[]>(this.baseUrl);
  }

getProduct(id)   {
  return this.http.get<Product>(this.baseUrl + id);
}
}
