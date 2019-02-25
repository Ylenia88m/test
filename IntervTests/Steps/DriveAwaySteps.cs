using System;
using TechTalk.SpecFlow;
using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace IntervTests.Steps
{
    [Binding]
    public class DriveAwaySteps
    {

        private string inputTextXpath = DriveAwayInsurance.InputText().ToString();
        private string sendButton = DriveAwayInsurance.SendRegistrationKeys().ToString();
        private string resultField = DriveAwayInsurance.ReadResultField().ToString();
        private string startDateResult = DriveAwayInsurance.ReadStartDate().ToString();
        private string endDateResult = DriveAwayInsurance.ReadEndtDate().ToString();
        private string noResourceFileds = DriveAwayInsurance.ReadNoResultField().ToString();
        private string rederror = DriveAwayInsurance.ReadredError().ToString();
        private string registrationNumberUnderTest;

        [Given(@"the user is on the DACC page")]
        public void GivenTheUserIsOnTheDACCPage()
        {
            Browser.Initialise();
            var title= (string)Browser.ExecuteJavaScript("return document.title");
            Assert.IsTrue((title == "Dealer Portal"));
        }

        [Given(@"the test Db is empty")]
        public void GivenTheTestDbIsEmpty()
        {      
            //test preparation step would ideally go here
            //toDo
        }

        [Given(@"the table x has a record for '(.*)' for StartDate '(.*)' and EndDate '(.*)'")]
        public void GivenTheTableXHasARecordForForStartDateAndEndDate(string p0, string p1, string p2)
        {
            //planting test data, I would do it here
            //toDo
        }

        [Given(@"I enter (.*)")]
        public void GivenIEnter(string registration)
        {
            Browser.ClickAndSendValue(inputTextXpath, registration);
            registrationNumberUnderTest = registration;
        }

        [When(@"I click Find Vehicle")]
        public void WhenIClickFindVehicle()
        {
            Browser.Click(sendButton);
        }

        [Then(@"the search will produce a result")]
        public void ThenTheSearchWillProduceAResult()
        {
            var text = Browser.readTextFromField(resultField);
            var registration = registrationNumberUnderTest;
            string expectedResult = "Result for : " + registration;
            bool testpassed = false;

            if (text == expectedResult) 
            {
                testpassed = true;
            }
            Assert.IsTrue(testpassed);
        }

        [Then(@"the result will have a cover Start and End date")]
        public void ThenTheResultWillHaveACoverStartAndEndDate()
        {
            var startdate = Browser.readTextFromField(startDateResult);
            var enddate = Browser.readTextFromField(endDateResult);
            Assert.IsNotNull(startdate);
            Assert.IsNotNull(enddate);

            //please note that here I would ask if the date has to be greater than current datetime for it to be valid, and crate an assertion according to this BR

        }

        [Then(@"the error message is displayed")]
        public void ThenTheErrorMessageIsDisplayed()
        {
            var text = Browser.readTextFromField(noResourceFileds);
            bool testpassed = false;

            if (text == "Sorry record not found")
            {
                testpassed = true;
            }
            else if (text == "Please enter a valid car registration")
            {
                testpassed = true;
            }
            Assert.IsTrue(testpassed);
        }

        [Then(@"the red error message is displayed")]
        public void ThenTheRedErrorMessageIsDisplayed()
        {
            var text = Browser.readTextFromField(rederror);
            bool testpassed = false;

            if (text == "Sorry record not found")
            {
                testpassed = true;
            }
            else if (text == "Please enter a valid car registration")
            {
                testpassed = true;
            }
            Assert.IsTrue(testpassed);
        }


        [Then(@"the results boolean (.*) matches expectations")]
        public void ThenTheResultsBooleanMatchesExpectations(string hasresult)
        {
            //string text = Browser.readTextFromField(resultField);
            string result = hasresult;
            bool testpassed = false;

            if (result == "True")
            {
                string text = Browser.readTextFromField(resultField);
                if (text.StartsWith("Result for"))
                {
                    testpassed = true;
                }
            }
            else if (result == "False")
            {
                string text = Browser.readTextFromField(noResourceFileds);
                if (text.StartsWith("Sorry record not found"))
                {
                    testpassed = true;
                }
            }

            Assert.IsTrue(testpassed);          
        }
        
        [AfterScenario]
        public void CloseTest()
        {        
            Browser.Quit();
        }
    }
}
