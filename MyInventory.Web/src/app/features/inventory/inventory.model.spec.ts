import {Inventory} from "./inventory.model";

export function getMockInventory(): Inventory[] {
  return [
    {
      inventoryId: '1',
      name: 'Coke',
      price: 6.54,
      quantity: 12,
      category: 'drink',
      description: '12oz soda drink.'
    },
    {
      inventoryId: '2',
      name: 'Mountain Dew',
      price: 7.05,
      quantity: 16,
      category: 'drink',
      description: '16oz soda drink.'
    },
    {
      inventoryId: '3',
      name: "Reese's Peanut Butter Cup",
      price: 4.25,
      quantity: 1,
      category: 'candy',
      description: '20 Piece bag of candy.'
    },
    {
      inventoryId: '4',
      name: 'Popcorn',
      price: 5.59,
      quantity: 4,
      category: 'snacks',
      description: 'Pre-made butter popcorn.'
    }
  ];
}
