Feature: LoginToWebApp
	Scenario depecting login functionality

@mytag
Scenario: Login to the WebApp using valid credentials.
	Given I have a valid url and navigated to the url.
	Then  I click on the Sign In button to go to User Sign In portal.
	When Redirected to the login portal, enter your valid username and password.
	And Click on Sign In button to proceed further.
	Then Verify if Login is successfull.
	And Select the users organistion.
	Then Click on continue button to finish with the login process.
	And click on logout button.

Scenario: Login to WebApp using invalid credentials.
    Given I have a valid url and navigated to the url.
	Then  I click on the Sign In button to go to User Sign In portal.
	When Redirected to the login portal, enter an invalid username and password.
	And Click on Sign In button to proceed further.
	Then Verify if Login is not successfull.