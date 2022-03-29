Feature: setupvmtest
	Simple calculator for adding two numbers


@regression
Scenario Outline: Open safeguard website and then check otp
Given Open safeguard webapplication in the browser
And enter the userid and password in the text box
When click on login button 
Then close the browser after login