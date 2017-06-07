import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {InventoryComponent} from "./features/inventory/inventory.component";
import {InventoryEditComponent} from "./features/inventory/inventory-edit/inventory-edit.component";

const routes: Routes = [
  {
    path: '',
    component: InventoryComponent
  },
  {
    path: 'edit/:id',
    component: InventoryEditComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule { }
