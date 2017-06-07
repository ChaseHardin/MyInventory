Feature: DeleteInventory

Scenario: Should delete inventory with a response of 200
	Given inventory exists
	When I DELETE 'api/inventory/{inventoryId}' with the following:
	"""
	{
		"inventoryId": "{inventoryId}",
	}
	"""
	Then the status should be 200