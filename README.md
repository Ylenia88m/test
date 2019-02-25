Automation framework in Selenium WebDriver
I've created a test framework with BDD technique in c# for a dummy application, click here to navigate to the website under test.

Background
SpeckFlow is a test automation tool following the principles of Behavioural Driven Design and living documentation. Specifications are written in a concise human readable form and executed in continuous integration.

This project allows you to have a comprehensive overview on how to implement a BDD framework in Selenium Webdriver with SpecFlow test framework. In order for this to work you must install some softwares and plugin as described below.

Set up and Installations
The prerequisites for running Selenium automation test suite:

Download & Install C#
Download and Install Visual Studio
Download Selenium WebDriver Client
install browser drivers (i.e. chromedriver)
Cucumber .jars files and Configure SpecFlow
add dependencies to POM
import plugins
Feature files - Acceptance Criteria
A Feature File is the entry point for a SpecFlow test where the features are described in BDD format/style, representing the “scaffolding” for each test. I’ve built feature files in the feature package. Each of them contains a list of scenarios (positive and negative). For example, below it's illustrated the test Feature:

test feature

These are structured in keywords defined by Gherkin.

Step definitions
A Step Definition is a java method in a class with an annotation above it. An annotation (@Given/ @When/ @Then) followed by the pattern is used to link the Step Definition to all the matching Steps, and the code is what Cucumber will execute when it sees a Gherkin Step.

Based on that, I’ve created the test suite classes in the stepdefinition package. For each of them I’ve defined all the methods with Gherkin annotation (@Given/ @When/ @Then). Please find here an example of class built with the concept of the step definition.

Testrunner class/ Generic Type Parameter
With a complete set of stepdefinions I procedeed to the creation of a class for running the tests. I’ve created a new Class file and named it ‘------‘, by right click on the Package and select New > Class. This class relies on the annotations to define which one of the cucumber features is being run through (please find screenshot below). More in detail, I’ve imported the statement ‘‘ in order to import the @RunWith annotation from the Junit class. Then, I’ve imported the statement ‘---------‘ in order to have access to the @CucumberOptions annotation. This annotation manages the logic under which Cucumber defines where to get a feature file and what reporting system will be used.

How to Run the Automation suite with VisualStudio
Finally, select the run option and then all the tests will be running correctly as below:
