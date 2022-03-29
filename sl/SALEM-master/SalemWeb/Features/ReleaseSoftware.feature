Feature: Release Software

@regressiontest
Scenario Outline: Release Software.
Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	#When After landing on website, click on organisation button and enter organisation name <OrgName> in searchbox.
	
	When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.

	Then Click on Release Software Button
	And Select product, version, License expiry date and max activations per day from dropdownmenu
	And Click on release button.
	And verify frelease of software.

@source:ReleaseSoftware.xlsx:Release
Examples: 
|Email|Password|Organisation|OrgName|

@regressiontest
Scenario Outline: Verifying Product dropdown.
Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	#When After landing on website, click on organisation button and enter organisation name <OrgName> in searchbox.
	
	When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.

	Then Click on Release Software Button
	And Select product from dropdownmenu.
@source:ReleaseSoftware.xlsx:Product
Examples: 
|Email|Password|Organisation|OrgName|

@regressiontest
Scenario Outline: Verifying version dropdown.
Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	#When After landing on website, click on organisation button and enter organisation name <OrgName> in searchbox.
	
	When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.

	Then Click on Release Software Button
	And select version from dropdownmenu.
@source:ReleaseSoftware.xlsx:Version
Examples: 
|Email|Password|Organisation|OrgName|

@regressiontest
Scenario Outline: Verifying license expiry date.
Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	#When After landing on website, click on organisation button and enter organisation name <OrgName> in searchbox.
	
	When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.

	Then Click on Release Software Button
	And select License expiry date.

@source:ReleaseSoftware.xlsx:LicenseExpiry
Examples: 
|Email|Password|Organisation|OrgName|

@regressiontest
Scenario Outline: Verifying max activation per day.
Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	#When After landing on website, click on organisation button and enter organisation name <OrgName> in searchbox.
	
	When After landing on website, click on organisation button.
 And enter organisation name <OrgName> in searchbox.

	Then Click on Release Software Button
	And select maxactivationper day.
@source:ReleaseSoftware.xlsx:MaxActivation
Examples: 
|Email|Password|Organisation|OrgName|
