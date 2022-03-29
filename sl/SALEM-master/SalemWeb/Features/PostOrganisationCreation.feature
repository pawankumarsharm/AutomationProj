Feature: PostOrganisationCreation
	
	@regressiontest
	Scenario Outline: Adding user to Organisation
	Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.
And Click on add user button.

 Then After landing on user page, select user role <Role> , enter firstname <FName>, lastname <LName>, emailid<EmailID>, contact number<Num>.
	And Click on Create Button to create new user for an organisation and specify all string <String>
	And verify user creation.


@source:PostOrganisationCreation.xlsx:AddUser
Examples: 
|Email|Password|Organisation|OrgName|Role|FName|LName|EmailID|Num|String|

@reGressionTest
Scenario Outline: Deleting an Organisation
Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

		When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.
	#And click on organisation to delete.

	Then Click on delete.
	And Verify deletion of user.
	@source:PostOrganisationCreation.xlsx:DeleteOrg
	Examples: 
	|Email|Password|Organisation|OrgName|

	@reGRessionTest
	Scenario Outline:  Send Email
	Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

		When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.

	Then click on email
	And verify email sent.
	@source:PostOrganisationCreation.xlsx:SendEmail
	Examples:
	|Email|Password|Organisation|OrgName|

	@reGressionTEST 
	Scenario Outline: Add role to user
	Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	#When  click on user button and enter username <UserName> in searchbox
	#And Click on user name to add role
	When after landing on website, click on user button.
	And enter user name <UserName> in searchbox

	Then select user role , Business Unit and Organisation from dropdownmenu.
	And click on add role button.
	And Verify role addition
	@source:PostOrganisationCreation.xlsx:AddRole
	Examples: 
	|Email|Password|Organisation|UserName|
	

	@reGressionTEst
	Scenario Outline: Remove role from user
	Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	When after landing on website, click on user button.
	And enter user name <UserName> in searchbox
	#And Click on user name to remove  role and scroll down
	And scroll down to remove role button.

	#Then Click on remove role button
	Then Click on confirm button to remove role.
	And verify removal of role.
	@source:PostOrganisationCreation.xlsx:RemoveRole
	Examples: 
	|Email|Password|Organisation|UserName|

	@reGressiONTEST 
Scenario Outline: Edit user
	Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	
	When after landing on website, click on user button.
	And enter user name <UserName> in searchbox
	

	Then click on edit button to edit user.
	And  click save.
	And verify user edit
	@source:PostOrganisationCreation.xlsx:EditUser
	Examples: 
	|Email|Password|Organisation|UserName|Num|