Feature: ApproveSoftwareRequest



@RegressionTest
Scenario Outline: Approving Software Request for a particular platform.
	Given Navigate to url.
    Then Click on Sign In button to proceed with approving software request. 
	And  After landing on sign in page. Enter email <Email> and <Password>
	Then Click on Sign in button.
	And  select organisation <Organisation> from dropdown menu and click on Continue button.

	When After landing  on website page, click on unapproved request button.
	And  Enter organistaion name <Org> in search box, Click on unapproved button.

	Then Click on Approve button to approved software request.
	And Click on Create Button.
	And  After landing on new organistaion page, click on Create Button
	And Verify against success message.
	@source:ApproveSoftware.xlsx:RequestApprove
	Examples: 
	|Email|Password|Organisation|Org|

@regressionTEst
Scenario Outline: Testing merge fuctionality.
Given Navigate to url.
Then Click on Sign In button to proceed with approving software request. 
And  After landing on sign in page. Enter email <Email> and <Password>
Then Click on Sign in button.
And  select organisation <Organisation> from dropdown menu and click on Continue button.

When After landing  on website page, click on unapproved request button.
And  Enter organistaion name <Org> in search box, Click on unapproved button.

Then Click on Approve button to approved software request.
And Click on merge Button
@source:ApproveSoftware.xlsx:TestMerge
Examples: 
|Email|Password|Organisation|Org|

@RegressionTEST
Scenario Outline: Testing search functionality of merge.
 Given Navigate to url.
 Then Click on Sign In button to proceed with approving software request. 
 And  After landing on sign in page. Enter email <Email> and <Password>
 Then Click on Sign in button.
 And  select organisation <Organisation> from dropdown menu and click on Continue button.

 When After landing  on website page, click on unapproved request button.
 And  Enter organistaion name <Org> in search box, Click on unapproved button.

 Then Click on Approve button to approved software request.
 And  enter in search box organistaion <OrgToMerge>, click search button.

@source:ApproveSoftware.xlsx:SearchFunction
Examples: 
|Email|Password|Organisation|Org|OrgToMerge|


@RegressionTEST
Scenario Outline: Merge to an exsisting organistaion.
 Given Navigate to url.
 Then Click on Sign In button to proceed with approving software request. 
 And  After landing on sign in page. Enter email <Email> and <Password>
 Then Click on Sign in button.
 And  select organisation <Organisation> from dropdown menu and click on Continue button.

 When After landing  on website page, click on unapproved request button.
 And  Enter organistaion name <Org> in search box, Click on unapproved button.
 
 Then  enter in search box organistaion <OrgToMerge>, click search button.
 And Select organisation name. Click on approve button and then merge button.
 And click on save button and select role <Role>from dropdown.
 And verify merge sucess.
 @source:ApproveSoftware.xlsx:MergeToOrg
 Examples: 
 |Email|Password|Organisation|Org|OrgToMerge|Role|

 @reGressionTeSt
 Scenario Outline: Reject unapproved Request.
  Given Navigate to url.
 Then Click on Sign In button to proceed with approving software request. 
 And  After landing on sign in page. Enter email <Email> and <Password>
 Then Click on Sign in button.
 And  select organisation <Organisation> from dropdown menu and click on Continue button.

  When After landing  on website page, click on unapproved request button.
 And  Enter organistaion name <Org> in search box, Click on unapproved button.

 Then click on reject button, and click on yes button.
 And Verify Rejection
 @source:ApproveSoftware.xlsx:Reject
 Examples: 
 |Email|Password|Organisation|Org|








	
