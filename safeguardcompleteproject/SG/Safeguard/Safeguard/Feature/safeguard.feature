Feature: safeguard
	Simple calculator for adding two numbers


Scenario: Open safeguard website and check links are working or not
	
	And click on the links and close the browser

Scenario: Open safeguard website and check header and footer 

	And check the header and footer of safeguard website


@dropdown
Scenario: Open Safeguard website and check dropdown function

	Given Open safeguard web application in the browser
	And Select the available product from dropdown
	Then close the browser

Scenario: Open safeguard website and change language

	Given open the safeguard webapplication
	And slect the language from change language dropdown



@regression
Scenario Outline: Open safeguard website and then check data validation
Given Open safeguard webapplication in the browserr 
And enter the <securecode> and <lotcode> in the text box
When click on check validation to validate the product 
Then close the browser after validation
@source:specexcel.xlsx:sheet1 
Examples:
|securecode|lotcode|

