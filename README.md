Automation framework using Selenium WebDriver
I've created a test framework with BDD technique in c# for a web application.

Background
SpeckFlow is a test automation tool following the principles of Behavioural Driven Development and living documentation. Specifications are written in a concise human readable form and executed in continuous integration.

This project allows you to have a comprehensive overview on how I implement a BDD framework in Selenium Webdriver with SpecFlow test framework. In order for this to work you must install some packages as described below.

Download and Install Visual Studio
Use the latest version of Chrome

Feature files - Acceptance Criteria
A Feature File is the entry point for a SpecFlow test where the features are described in BDD format/style, representing the “scaffolding” for each test. I’ve built feature files in the feature package. Each of them contains a list of scenarios (positive and negative). For example, below it's illustrated the test Feature:

test feature
These are structured in keywords defined by Gherkin.

Step definitions
A Step Definition is bound to a C# method. An annotation (@Given/ @When/ @Then) followed by the pattern is used to link the Step Definition to all the matching Steps, and the code is what Cucumber will execute when it sees a Gherkin Step.

Test Teardown
This is executed at the end of every test to clean up and start fresh every other test

Parametised tests
I used scenarios outline to run parametised tests

How to Run the Automation suite with VisualStudio
Built solution and projects, execute tests that will appear in the test finder


Tests out of scope of this demonstration (but that I would execute in real life):

I would write acceptance criterias to prove that the user can use the navigation on the page under test, that the page works on different browsers and screen resolutions as well as supporting the load it is intended to have. 

Page object model:
this code is designed to use a page object model so that other tests can be implemented and each page is a class that has its unique characteristics and that deals with its "responsabilities". Doing that I try to reduce code smell.

