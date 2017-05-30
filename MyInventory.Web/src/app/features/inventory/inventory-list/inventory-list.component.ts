import { Component, OnInit } from '@angular/core';
import {Inventory} from "../inventory.model";
import { getMockInventory } from '../../index';

@Component({
  selector: 'app-inventory-list',
  templateUrl: './inventory-list.component.html',
  styleUrls: ['./inventory-list.component.css']
})
export class InventoryListComponent implements OnInit {
  inventory: Inventory[];

  constructor() { }

  ngOnInit() {
    this.inventory = getMockInventory();
  }
}
