Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Open safeguard website and then check data validation

	Given Open shopping webapplication in the browser
	And select Dress
	Then select Casual Dress
	Then Add to cart the project
	Then Proceed to checkout
	Then login with <email> and <password>
	Then click on Update the Address
	Then Change the State and save
	Then Add the comment
	Then Click on proceed to checkout
	Then Click on proceed to checkout terms
	When a message will appear
	Then click on close
	Then Now Check the Terms of Service checkbox
	Then Proceed to checkoutt
	Then now read total price
	Then click on pay by bank wire
	Then click on confirm my order
	Then save the screenshot from for the confirmation page 
@source:shopexcel.xlsx:sheet1 
Examples:
|email|password|

