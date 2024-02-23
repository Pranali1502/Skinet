import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from './shared/models/product';
import { Pagination } from './shared/models/Pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Skinet';
  products: Product[]=[];
  constructor(private http: HttpClient){}

  ngOnInit(): void {
    this.http.get<Pagination<Product[]>>('https://localhost:5001/api/products?pageSize=18').subscribe({
      next: response => this.products = response.data,
      error: err=> console.log(err),
      complete: ()=>{
        console.log("Completed");
      }
    })
  }
}
