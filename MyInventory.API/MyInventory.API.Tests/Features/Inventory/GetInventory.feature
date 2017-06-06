Feature: GetInventory

Scenario: Should return all inventory items
	Given inventory exists
	When I GET 'api/inventory'
	Then the status should be 200
	And the JSON at '[inventoryId={inventoryId}].inventoryId' should be '{inventoryId}'
	And the JSON at '[inventoryId={inventoryId}].price' should be '22.25'
	And the JSON at '[inventoryId={inventoryId}].quantity' should be '4'
	And the JSON at '[inventoryId={inventoryId}].description' should be 'Freshly cut prime rib'
	And the JSON at '[inventoryId={inventoryId}].category' should be 'Meat'
	And the JSON at '[inventoryId={inventoryId}].name' should be 'Prime Rib'