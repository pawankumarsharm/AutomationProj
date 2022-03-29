Feature: MixtureAcidValidations
	Validating the Service Life mixtures

Scenario: 01 Acid Validations AcetonitrileFormamide
	Given I have already navigated to the SLS WebPage
	Then  I select the AF acid and set their respective exposure values.
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details click on next button to proceed further.
	Then  Verify teh Service Life Estimate and then click on Done button to complete the verification process.

	@regression
Scenario: 02 Acid Validations HexaneStyrene
	Given I have already navigated to the SLS WebPage
	Then  I select the HS acid and set their respective exposure values.
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for HS Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for HS Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for HS Acid Mixture and then click on Done button to complete the verification process.
	
	@regression
Scenario: 03 Acid Validations HFSO
	Given I have already navigated to the SLS WebPage
	Then  I select the HFSO acid  
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for HFSO Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for HFSO Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for HFSO Acid Mixture and then click on Done button to complete the verification process.

	@regression
Scenario: 04 Acid Validations AmmoniaMethylamine
	Given I have already navigated to the SLS WebPage
	Then  I select the AM acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AmmoniaMethylamine Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AmmoniaMethylamine Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for AmmoniaMethylamine Acid Mixture and then click on Done button to complete the verification process.

	@regression
Scenario: 05 Acid Validations AmmoniaMethylamine_mg3
	Given I have already navigated to the SLS WebPage
	Then  I select the AM acid with exposure unit as mg 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AmmoniaMethylamine Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AmmoniaMethylamine Acid Mixture_mg3 click on next button to proceed further.
	Then  Verify the Service Life Estimate for AmmoniaMethylamine Acid Mixture_mg3 and then click on Done button to complete the verification process.

	@regression
Scenario: 06 Acid Validations AmmoniaMethylamine_mg3
	Given I have already navigated to the SLS WebPage
	Then  I select the AM acid with exposure unit as mg3 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AmmoniaMethylamine Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AmmoniaMethylamine Acid MixtureMg click on next button to proceed further.
	Then  Verify the Service Life Estimate for AmmoniaMethylamine Acid MixtureMg and then click on Done button to complete the verification process.

	@regression
Scenario: 07 Acid Validations AmmoniaSO2_ppm
	Given I have already navigated to the SLS WebPage
	Then  I select the ASO2 acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for ASO2 Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for ASO2 Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for ASO2 Acid Mixture and then click on Done button to complete the verification process.

	@regression
Scenario: 08 Acid Validations H2SSO2
	Given I have already navigated to the SLS WebPage
	Then  I select the H2SSO2 acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for H2SSO2 Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for H2SSO2 Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for H2SSO2 Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 09 Acid Validations AcetoneSO2
	Given I have already navigated to the SLS WebPage
	Then  I select the AcetoneSO2 acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AcetoneSO2 Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AcetoneSO2 Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for AcetoneSO2 Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 10 Acid Validations TouleneAmmonia_ppm
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneAmmonia acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneAmmonia Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneAmmonia Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneAmmonia Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 11 Acid Validations TouleneAmmonia(mg3)
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneAmmonia2 acids 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneAmmonia Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneAmmonia Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneAmmonia2 Acid Mixture and then click on Done button to complete the verification process.
    @regression
Scenario: 12 Acid Validations AmmoniaSulfurDioxide
	Given I have already navigated to the SLS WebPage
	Then  I select the AmmoniaSulfurDioxide acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AmmoniaSulfurDioxide Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AmmoniaSulfurDioxide Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for AmmoniaSulfurDioxide Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 13 Acid Validations AmmoniaSulfurDioxide
	Given I have already navigated to the SLS WebPage
	Then  I select the AmmoniaSulfurDioxide1 acids 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AmmoniaSulfurDioxide Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AmmoniaSulfurDioxide Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for AmmoniaSulfurDioxide1 Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 14 Acid Validations TouleneSulfurDioxide
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneSulfurDioxide acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneSulfurDioxide Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneSulfurDioxide Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneSulfurDioxide Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 15 Acid Validations TouleneSulfurDioxide1
	Given I have already navigated to the SLS WebPage
	Then I select the TouleneSulfurDioxide acid
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneSulfurDioxide Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneSulfurDioxide1 Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneSulfurDioxide1 Acid Mixture and then click on Done button to complete the verification process.
#    @regression
#Scenario: 16 Acid Validations TouleneMEK
#	Given I have already navigated to the SLS WebPage
#	Then  I select the TouleneMEK acid 
#	And   I click on next button and then click on Done button on Refine Result 
#	Then  I filter the required cartidge/filter using the cartidge value for TouleneMEK Acid Mixture	
#	When  I click on the Select And Continue button , I should be in environment setup page.
#	And   After setting up the environment details for TouleneMEK Acid Mixture click on next button to proceed further.
	#Then  Verify the Service Life Estimate for TouleneMEK Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 16 Acid Validations AcetonitrileMethylineChlorideFormamide
	Given I have already navigated to the SLS WebPage
	Then  I select the AcetonitrileMethylineChlorideFormamide acid 
	And   I click on next button and then click on Done button on Refine Result for AcetonitrileMethylineChlorideFormamide
	Then  I filter the required cartidge/filter using the cartidge value for AcetonitrileMethylineChlorideFormamide Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AcetonitrileMethylineChlorideFormamide Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for AcetonitrileMethylineChlorideFormamide Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 17 Acid Validations TouleneSOAmmonia
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneSOAmmonia acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneSOAmmonia Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneSOAmmonia Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneSOAmmonia Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 18 Acid Validations TouleneHexSO2HF
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneHexSO2HF acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneHexSO2HF Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneHexSO2HF Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneHexSO2HF Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 19 Acid Validations TouleneHexSO2HF
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneHexSO2HF2 acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneHexSO2HF Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneHexSO2HF2 Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneHexSO2HF2 Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 20 Acid Validations TouleneHexAmmoniaMeth
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneHexAmmoniaMeth acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneHexAmmoniaMeth Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneHexAmmoniaMeth Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneHexAmmoniaMeth Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 21 Acid Validations SulphurHFAmmoniaMeth
	Given I have already navigated to the SLS WebPage
	Then  I select the SulphurHFAmmoniaMeth acid
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for SulphurHFAmmoniaMeth Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for SulphurHFAmmoniaMeth Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for SulphurHFAmmoniaMeth Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 22 Acid Validations TouleneAceticMEKXylene
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneAceticMEKXylene acid
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneAceticMEKXylene Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneAceticMEKXylene Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneAceticMEKXylene Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 23 Acid Validations TouleneAceticMEKXylene2
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneAceticMEKXylene2 acid 
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneAceticMEKXylene Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneAceticMEKXylene2 Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneAceticMEKXylene2 Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 24 Acid Validations AmmoniaHFHSSO2Methy
	Given I have already navigated to the SLS WebPage
	Then  I select the AmmoniaHFHSSO2Methy acid
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for AmmoniaHFHSSO2Methy Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for AmmoniaHFHSSO2Methy Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for AmmoniaHFHSSO2Methy Acid Mixture and then click on Done button to complete the verification process.
	@regression
Scenario: 25 Acid Validations TouleneHexaneSO2HFAmmoniaMethylamine
	Given I have already navigated to the SLS WebPage
	Then  I select the TouleneHexaneSO2HFAmmoniaMethylamine acid
	And   I click on next button and then click on Done button on Refine Result 
	Then  I filter the required cartidge/filter using the cartidge value for TouleneHexaneSO2HFAmmoniaMethylamine Acid Mixture	
	When  I click on the Select And Continue button , I should be in environment setup page.
	And   After setting up the environment details for TouleneHexaneSO2HFAmmoniaMethylamine Acid Mixture click on next button to proceed further.
	Then  Verify the Service Life Estimate for TouleneHexaneSO2HFAmmoniaMethylamine Acid Mixture and then click on Done button to complete the verification process.