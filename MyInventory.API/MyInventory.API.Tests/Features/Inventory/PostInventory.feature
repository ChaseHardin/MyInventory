Feature: PostInventory

Scenario: Should return 201 on successful create
	When I POST 'api/inventory/' with the following:
	"""
	{
		"name": "Candy Corn",
		"description": "Fun bag of candy",
		"category": "candy",
		"quantity": "2",
		"price": "4.95"
	}
	"""
	Then the status should be 201
	And the 'Content-Type' header should match regex 'application/json'