import { Injectable } from '@angular/core';
import {Http, Response, Headers, RequestOptions} from '@angular/http';
import 'rxjs/add/operator/map';
import {Inventory} from "./inventory.model";

@Injectable()
export class InventoryService {

  constructor(private http: Http) { }

  getInventory() {
    return this.http.get('http://localhost:53646/api/inventory').map((res: Response) => res.json());
  }

  deleteInventory(inventoryId: string) {
    return this.http.delete(`http://localhost:53646/api/inventory/${inventoryId}`);
  }

  getInventoryById(inventoryId: string) {
    return this.http.get(`http://localhost:53646/api/inventory/${inventoryId}`).map((res: Response) => res.json());
  }

  updateInventory(inventory: Inventory) {
    debugger;
    let headers = new Headers ({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    let body = JSON.stringify(inventory);
    return this.http.put(`http://localhost:53646/api/inventory/${inventory.inventoryId}`, body, options ).map((res: Response) => res.json());
  }
}
