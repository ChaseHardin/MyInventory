Feature: PutInventory

Scenario: Should update inventory with a response of 200
	Given inventory exists
	When I PUT 'api/inventory/{inventoryId}' with the following:
	"""
	{
		"inventoryId": "{inventoryId}",
		"name": "Candy Corn",
		"description": "Fun bag of candy",
		"category": "candy",
		"quantity": "2",
		"price": "4.95"
	}
	"""
	Then the status should be 200
	And the 'Content-Type' header should match regex 'application/json'