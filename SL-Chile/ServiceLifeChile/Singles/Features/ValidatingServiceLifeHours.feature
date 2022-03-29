Feature: ValidatingServiceLifeHours
	Validating the Hours for the Cartidges

Scenario Outline: Service Life Hours Validation.
Given I have navigated to SLS Web Application.
Then I set region as <Region> from sheet.
And I click on the next button to proceed further.
Then In the Setup page I select the Service Life result and click on IAccept to continue.
And In the contaminant page I filter the Contaminants using <Cas_Number> and set the <Exposure> and <Exposure_Unit>
And In the refine page I click on done button.
Then In the filter page select the solution <Cartridge> that works for you.
And In Environment page I set the details of <Relative_Humidity>,<Atmospheric_Pressure>,<Temperature>,<Temperature_Unit> and <Work_Rate>
Then I verify the <Hours> in the review page.
@source:Servicelife_Testcases_Chile.xlsx:main
Examples: 
|S.No|Contaminate|Cas_Number|Exposure|Exposure_Unit|Cartridge|Relative_Humidity|Atmospheric_Pressure|Temperature|Temperature_Unit|Work_Rate|Hours|Exposure_Limit|Exposure_Limit_Unit|Region|