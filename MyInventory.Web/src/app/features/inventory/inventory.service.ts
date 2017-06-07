import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';

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
}
