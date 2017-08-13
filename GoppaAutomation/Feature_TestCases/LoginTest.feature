Feature: Login Action
		 In order to have multiple tests I should have valid Credentials
		 And should be able to login and logout from Goppa

@BeforeallTest
Scenario: Successful Login with Valid Credentials
	Given User is on Goppa Home Page
	When User Navigate to LogIn Page
	And User enters "Email" and "Password"
	Then  New user is loged in  Successfully

Scenario: Successful LogOut
	When User LogOut from the Goppa
	Then  LogOut is done Successfully 