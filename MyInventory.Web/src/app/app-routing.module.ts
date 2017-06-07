import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {InventoryComponent} from "./features/inventory/inventory.component";

const routes: Routes = [
  {
    path: '',
    component: InventoryComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule { }
