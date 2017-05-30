import { Component, OnInit } from '@angular/core';
import {Inventory} from "./inventory.model";
import { getMockInventory } from '../index';

@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.css']
})
export class InventoryComponent implements OnInit {

  inventory: Inventory[];
  constructor() { }

  ngOnInit() {
    this.inventory = getMockInventory();
  }
}
