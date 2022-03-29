Feature: RequestSoftware
	Requesting for required software for Desktop or Mobile Types

@RegressionTest
Scenario Outline: Requesting Software for a particular platform.
	Given I have a valid url and navigated to the url.
	Then Click on Show Software button to proceed with requesting of requried software.
	And Set the Filter to the required platform Desktop/Mobile <Platform> as per requirement.
	Then Click on the See Details button for the required software <Software> to proceed further.
	When Landed to Software page click on Request button to proceed further.
	And Enter your Email <email> and click on verify button.
	Then Enter your details such as First Name <Fname>,Last Name <Lname>,Organization Name <OrgName>,Country <country>,State<state> and City<city>.
	And Click on Register Button.
	@source:RequestData.xlsx
	Examples: 
	|S.No|Platform|Software|email|Fname|Lname|OrgName|country|state|city|