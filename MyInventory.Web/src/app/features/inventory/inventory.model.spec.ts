import {Inventory} from "./inventory.model";

export function getMockInventory(): Inventory[] {
    return [
        {
            inventoryId: '1',
            name: 'Coke',
            price: 6.54,
            quantity: 12,
            category: 'drink'
        },
        {
            inventoryId: '2',
            name: 'Mountain Dew',
            price: 7.05,
            quantity: 12,
            category: 'drink'
        },
        {
            inventoryId: '3',
            name: "Reese's Peanut Butter Cup",
            price: 4.25,
            quantity: 1,
            category: 'candy'
        },
    ];
}