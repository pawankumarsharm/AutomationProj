Feature: CreateOrganisation
	Creating new Organisation

@mytag
Scenario Outline: Create a new Organisation
Given I have a valid url and navigated to the url.
Then  I click on the Sign In button to go to User Sign In portal.
When Redirected to the login portal, enter your valid username and password.
And Click on Sign In button to proceed further.
Then Verify if Login is successfull.
And Select the users organistion.
Then Click on continue button to finish with the login process. 
And Click on the Organisations link to redirect to Organisation DashBoard.
Then In the Organisation Dashboard, tap on the CreateNewOrganisation button to proceed with the new organisation creation.
When Redirected to the CreateOrganistion dashboard, fill the necessary details such as <OrgName>,<FirstName>,<Country>,<LastName>,<State>,<Email>,<City>,<ContactNumber>,<Bussiness_Unit>,<Account_Type>,<Field>,<Status>
Then Click on Create button to complete with the Organisation creation.
And Verify that new Organisation is created successfully or not.
And click on logout button.
@source:OrganisationCreateData.xlsx
Examples:
|OrgName|Country|State|City|Bussiness_Unit|Account_Type|Field|Status|FirstName|LastName|Email|ContactNumber|

@mytag
Scenario Outline: Cancel Button Validation
Given I have a valid url and navigated to the url.
Then  I click on the Sign In button to go to User Sign In portal.
When Redirected to the login portal, enter your valid username and password.
And Click on Sign In button to proceed further.
Then Verify if Login is successfull.
And Select the users organistion.
Then Click on continue button to finish with the login process. 
And Click on the Organisations link to redirect to Organisation DashBoard.
Then In the Organisation Dashboard, tap on the CreateNewOrganisation button to proceed with the new organisation creation.
When Redirected to the CreateOrganistion dashboard, fill the necessary details such as <OrgName>,<FirstName>,<Country>,<LastName>,<State>,<Email>,<City>,<ContactNumber>,<Bussiness_Unit>,<Account_Type>,<Field>,<Status>
Then Click on Cancel Button and verify if Organization creation is canceled successfully.
And click on logout button.
@source:OrganisationCreateData.xlsx
Examples:
|OrgName|Country|State|City|Bussiness_Unit|Account_Type|Field|Status|FirstName|LastName|Email|ContactNumber|

@mytag
Scenario Outline: Required Feild Validation.
Given I have a valid url and navigated to the url.
Then  I click on the Sign In button to go to User Sign In portal.
When Redirected to the login portal, enter your valid username and password.
And Click on Sign In button to proceed further.
Then Verify if Login is successfull.
And Select the users organistion.
Then Click on continue button to finish with the login process. 
And Click on the Organisations link to redirect to Organisation DashBoard.
Then In the Organisation Dashboard, tap on the CreateNewOrganisation button to proceed with the new organisation creation.
When Redirected to the CreateOrganistion dashboard, fill the necessary details such as <OrgName>,<FirstName>,<Country>,<LastName>,<State>,<Email>,<City>,<ContactNumber>,<Bussiness_Unit>,<Account_Type>,<Field>,<Status>
Then Click on Create button to complete with the Organisation creation.
And Verify that no new Organisation is created successfully or not.
And click on logout button.
@source:EmptyFields.xlsx
Examples:
|OrgName|Country|State|City|Bussiness_Unit|Account_Type|Field|Status|FirstName|LastName|Email|ContactNumber|