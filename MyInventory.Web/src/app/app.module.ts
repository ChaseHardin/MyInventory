import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './features/home/home.component';
import { TopNavComponent } from './features/top-nav/top-nav.component';
import { InventoryComponent } from './features/inventory/inventory.component';
import { AddInventoryComponent } from './features/inventory/add-inventory/add-inventory.component';
import { AlertModule } from 'ng2-bootstrap/ng2-bootstrap';
import { ManageComponent } from './features/inventory/manage/manage.component';
import { EditComponent } from './features/inventory/edit/edit.component';
import { InventoryListComponent } from './features/inventory/inventory-list/inventory-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TopNavComponent,
    InventoryComponent,
    AddInventoryComponent,
    ManageComponent,
    EditComponent,
    InventoryListComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    AlertModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
