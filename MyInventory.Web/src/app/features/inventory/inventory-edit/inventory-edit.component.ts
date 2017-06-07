import { Component, OnInit } from '@angular/core';
import {InventoryService} from "../inventory.service";
import {ActivatedRoute, Params} from "@angular/router";
import {Inventory} from "../inventory.model";

@Component({
  selector: 'app-inventory-edit',
  templateUrl: './inventory-edit.component.html',
  styleUrls: ['./inventory-edit.component.css']
})
export class InventoryEditComponent implements OnInit {
  inventoryId: string;
  inventory: Inventory;

  constructor(private service: InventoryService, private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.initInventoryId();
    this.getInventory();
  }

  private getInventory() {
    this.service.getInventoryById(this.inventoryId).subscribe(inventory => this.inventory = inventory);
  }

  private initInventoryId() {
    this.activatedRoute.params.subscribe((params: Params) => {
      this.inventoryId = params['id'];
    });
  }
}
