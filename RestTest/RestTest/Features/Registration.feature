Feature: Registration
	In order to add my company
	As a user
	I want to register

@register
Scenario: Successful registration
	Given Genereted user input <name> <email> <password>
	Then I make doRegistration request with generated data
	Then I get server response status code 200
	Then I get server response in the body "name" : <name>
	Then I get server response in the body "email" : <email>



