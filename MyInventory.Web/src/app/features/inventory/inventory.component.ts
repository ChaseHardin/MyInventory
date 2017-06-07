import { Component, OnInit } from '@angular/core';
import {Inventory} from "./inventory.model";
import {InventoryService} from "./inventory.service";

@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.css']
})
export class InventoryComponent implements OnInit {
  inventory: Inventory[];

  constructor(private service: InventoryService) { }

  ngOnInit() {
    this.initInventory();
  }

  deleteInventory(inventory: Inventory) {
    this.service.deleteInventory(inventory.inventoryId).subscribe((res) => {
      var index = this.inventory.indexOf(inventory);
      this.inventory.splice(index, 1);
    });
  }

  private initInventory() {
    this.service.getInventory().subscribe(data => this.inventory = data);
  }
}
