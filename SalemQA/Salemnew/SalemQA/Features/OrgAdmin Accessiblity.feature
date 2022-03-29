Feature: OrgAdmin Accessiblity
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Org Admin Accessiblity Improvements.
	Given User navigates to the Salem Home Page.
	Then In the Home Page, Click on the Login Link and enter the <orgusername> and <orgpas> to login with OrgAdmin account.
	And Select the users organistion <org>
	When Logged in verify if able to add users.
	Then Verify if user is able to download the assigned software.
	And Verify if user is able to request the unassigned software.

	@source:data.xlsx:sheet1
	Examples:
		| orgusername| orgpas|org|

Scenario Outline: Software has been realeased to Organization without an Org Admin
	Given User navigates to the Salem Home Page.
	Then In the Home Page, Click on the Login Link and enter the <orgusername> and <orgpas> to login with super admin.
	And Select the users organistion.
	Then Navigate to Orgnazation and create a new one <OrgName>,<FirstName>,<Country>,<LastName>,<State>,<Email>,<City>,<ContactNumber>,<Bussiness_Unit>,<Account_Type>,<Field>,<Status>
	And Verify Software cannot be released without org admin.

	@source:OrganisationCreateData.xlsx
	Examples:
		|orgusername|orgpas|OrgName|Country|State|City|Bussiness_Unit|Account_Type|Field|Status|FirstName|LastName|Email|ContactNumber|

Scenario Outline: Org Admin Localization issue.
	Given User navigates to the Salem Home Page.
	Then In the Home Page, Click on the Login Link and enter the <orgusername> and <orgpas> to login with OrgAdmin account.
	And Select the users organistion <org>
	When Logged in verify localization based on language selected.

	@source:data.xlsx:sheet1
	Examples:
		| orgusername| orgpas|org|

Scenario Outline: Org Admin should able to create another org admin.
	Given User navigates to the Salem Home Page.
	Then In the Home Page, Click on the Login Link and enter the <orgusername> and <orgpas> to login with OrgAdmin account.
	And Select the users organistion <org>
	When Logged in, then verify if Org Admin option is available in the user creation page.

	@source:data.xlsx:sheet1
	Examples:
		| orgusername| orgpas|org|

Scenario Outline: Org Admin should not see expires on in the Software Section.
	Given User navigates to the Salem Home Page.
	Then In the Home Page, Click on the Login Link and enter the <orgusername> and <orgpas> to login with OrgAdmin account.
	And Select the users organistion <org>
	When Logged in, then verify if Org Admin does not have Expires on Column in Software Section.

	@source:data.xlsx:sheet1
	Examples:
		| orgusername| orgpas|org|