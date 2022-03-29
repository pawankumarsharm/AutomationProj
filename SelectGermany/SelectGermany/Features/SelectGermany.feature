Feature: SelectGermany
     Validate the total cartidges for the below scenarios.
@regression
Scenario Outline: Validate the Cartidges.
	Given I have navigated to the SLS Website
	When I select the  <Region> provided  and click on the next button
	Then I select Cartidge/Filter check box and proceed further till data validation
	And I have <CasNumber> and <Contaminant> to filter the product and I filter the product
	Then I select the filtered products using the Cas <CasNumber> or the Contaminants Value <Contaminant>
	And  Click on the next button		  
	Then I Filter the contaminants using the filter values <Gases_or_Vapors_also_Present?>,<Particles_Present?>,<Respirator_Type>,<Filter_Class>,<Cartidge>,<CasNumber> and <Text_Message>
	And I do the final validation of the elements with the serial no. <S.No> , <CasNumber>,<Region>,<Text_Message> and <Total_Element_Count>
	@source:Select_Germany.xlsx:sheet1
	Examples:
	|S.No|Is_Mixture?|Contaminant|CasNumber|Recommended_Respirator|Gases_or_Vapors_also_Present?|Particles_Present?|Respirator_Type|Filter_Class|Cartidge|Disposable|Resusable(facepiece_and_filter_together_as_complete_system)|Resuable(cartidge/filter)|PAPR(cartidge/filter)|Total_Contaminants|Total_Element_Count|Text_Message|Region|