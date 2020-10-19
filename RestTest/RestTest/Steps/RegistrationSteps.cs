using RestSharp;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace RestTest.Steps
{

    [Binding]
    public class RegistrationSteps
    {
        RestClient client;
        RestRequest request;
        Dictionary<string, string> UserData;

        [Given(@"Genereted user input (.*) (.*) (.*)")]
        public void GivenGeneretedUserInput(string p0, string p1, string p2)
        {
            client = new RestClient("http://users.bugred.ru");
            string randomDateString = DateTime.Now.ToString()
                .Replace(".", "")
                .Replace("/", "")
                .Replace("PM", "")
                .Replace(":", "");
            UserData = new Dictionary<string, string>
            {
                {"name", randomDateString },
                {"email", randomDateString + "@" + randomDateString.Substring(0,4) + "." + randomDateString.Substring(0,3) },
                {"password", randomDateString + "qwerty" }
            };
        }


        [Then(@"I make doRegistration request with generated data")]
        public void ThenIMakeDoRegistrationRequestWithGeneratedData()
        {
            request = new RestRequest(" /tasks/rest/doregister", Method.POST);
        }
        
        [Then(@"I get server response status code (.*)")]
        public void ThenIGetServerResponseStatusCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get server response in the body ""(.*)"" : (.*)")]
        public void ThenIGetServerResponseInTheBody(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
