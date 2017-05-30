import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryComponent } from './inventory.component';
import { getMockInventory } from '../index';

describe('InventoryComponent', () => {
  let component: InventoryComponent;
  let fixture: ComponentFixture<InventoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InventoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InventoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });

  it('should have table styles', () => {
    expect(fixture.nativeElement.querySelector('table').classList.toString()).toEqual('table table-hover');
  });

  it('should bind table data', () => {
    let inventory = getMockInventory();
    fixture.componentInstance.inventory = inventory;
    fixture.detectChanges();

    expect(fixture.nativeElement.querySelector('[name=name]').textContent).toEqual(inventory[0].name);
    expect(fixture.nativeElement.querySelector('[name=price]').textContent).toEqual(inventory[0].price.toString());
    expect(fixture.nativeElement.querySelector('[name=quantity]').textContent).toEqual(inventory[0].quantity.toString());
    expect(fixture.nativeElement.querySelector('[name=category]').textContent).toEqual(inventory[0].category.toString());
  });

  it('should have styled button with appropriate text', () => {
    let inventory = getMockInventory();
    fixture.componentInstance.inventory = inventory;
    fixture.detectChanges();

    expect(fixture.nativeElement.querySelector('[name=selectBtn] button').classList.toString()).toEqual('btn btn-primary');
    expect(fixture.nativeElement.querySelector('[name=selectBtn] button i').classList.toString()).toEqual('glyphicon glyphicon-plus');
    expect(fixture.nativeElement.querySelector('[name=selectBtn] button').textContent).toEqual(' Add');
  });
});
