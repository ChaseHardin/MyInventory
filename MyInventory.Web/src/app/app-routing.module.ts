import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from "./features/home/home.component";
import {InventoryComponent} from "./features/inventory/inventory.component";
import {ManageComponent} from "./features/inventory/manage/manage.component";

const routes: Routes = [
  {
    path: 'home', component: HomeComponent
  },
  {
    path: 'inventory', component: InventoryComponent
  },
  {
    path: 'manage', component: ManageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
