Feature: SoftwarePortal
	Test the functionality of Software Portal

@mytag
Scenario: 03 Verify available software is displayed in the the portal.
	Given I have logged in to the Salem web portal using a valid credentials.
	And I choose the organisation/groups to continue with
	| Organistaion |
	|3M Internal Group|
	Then I navigate to the software portal.
	And Verify the list of displayed softwares.

Scenario: 02 Verify that the search functionality is working in the software portal page.
	Given I have logged in to the Salem web portal using a valid credentials.
	And I choose the organisation/groups to continue with
	| Organistaion |
	|3M Internal Group|
	Then I navigate to the software portal.
	And I enter a particular software to search in the search box.
	| Software |
	|TestQAKSV1|
	Then Verify if the filtered software exists or not.

Scenario: 04 Verify if the edit functionality is working as expected.
    Given I have logged in to the Salem web portal using a valid credentials.
	And I choose the organisation/groups to continue with
	| Organistaion |
	|3M Internal Group|
	Then I navigate to the software portal.
	And I enter a particular software to search in the search box.
	| Software |
	|TestQAKSV1|
	Then Verify if the filtered software exists or not.
	Then I click on the edit button.
	And I modify the values in the software description.
	| Name | Bussiness_Unit | Trial_Period | Def_Max_Act_Key | Ava_for_self_req |
	|TestQAKSV1|3M Scott|     3         |          5       |      No            |

Scenario:05 Delete a particular Software.
    Given I have logged in to the Salem web portal using a valid credentials.
	And I choose the organisation/groups to continue with
	| Organistaion |
	|3M Internal Group|
	Then I navigate to the software portal.
	And I enter a particular software to search in the search box.
	| Software |
	|TestQAKSV1|
	Then Verify if the filtered software exists or not.
	And  I Click on the delete button.
	Then Click on Ok button to confirm the deletion.

Scenario: 01 Create a new Software.
    Given I have logged in to the Salem web portal using a valid credentials.
	And I choose the organisation/groups to continue with
	| Organistaion |
	|3M Internal Group|
	Then I navigate to the software portal.
	And I click on Add New Software Button.
	Then I enter the software details.
	| NameSftwre      | SoftwareType | Available_SelfRequest | BussinessUnit | BetaSoftware | ShortDesc                                    |
	| TestQAKSV1 | MOBILE      | Yes                   | 3M Scott      | Yes          | This QA test software. Will be deleted soon. |
	And Click on create button.
	Then Verify the success message.