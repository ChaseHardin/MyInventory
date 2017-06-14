import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { InventoryComponent } from './features/inventory/inventory.component';
import {InventoryService} from "./features/inventory/inventory.service";
import {AlertModule} from "ng2-bootstrap";
import { InventoryEditComponent } from './features/inventory/inventory-edit/inventory-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    InventoryComponent,
    InventoryEditComponent,
    InventoryEditComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    AlertModule.forRoot(),
  ],
  providers: [
    InventoryService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
