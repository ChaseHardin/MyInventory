Feature: GetInventoryById

Scenario: Should return inventory by id
	Given inventory exists
	When I GET 'api/inventory/{inventoryId}'
	Then the status should be 200
	And the JSON at 'inventoryId' should be '{inventoryId}'
	And the JSON at 'price' should be '22.25'
	And the JSON at 'quantity' should be '4'
	And the JSON at 'description' should be 'Freshly cut prime rib'
	And the JSON at 'category' should be 'Meat'
	And the JSON at 'name' should be 'Prime Rib'