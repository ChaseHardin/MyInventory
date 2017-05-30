import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryListComponent } from './inventory-list.component';
import {getMockInventory} from "../inventory.model.spec";

describe('InventoryListComponent', () => {
  let component: InventoryListComponent;
  let fixture: ComponentFixture<InventoryListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InventoryListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InventoryListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });

  it('should bind data', () => {
    expect(fixture.nativeElement.querySelector('a span').textContent).toEqual(getMockInventory()[0].quantity.toString());
    expect(fixture.nativeElement.querySelector('a h4').textContent).toEqual(getMockInventory()[0].name);
    expect(fixture.nativeElement.querySelector('a p').textContent).toEqual(getMockInventory()[0].description);
  });

  it('should show badge styling', () => {
    expect(fixture.nativeElement.querySelector('a span').classList.toString()).toEqual('badge');
  });

  it('should show title styling', () => {
    expect(fixture.nativeElement.querySelector('a h4').classList.toString()).toEqual('list-group-item-heading');
  });

  it('should show sub header styling', () => {
    expect(fixture.nativeElement.querySelector('a p').classList.toString()).toEqual('list-group-item-text');
  });

  it('should have list-group styling', () => {
    expect(fixture.nativeElement.querySelector('div').classList.toString()).toEqual('list-group');
  });
});