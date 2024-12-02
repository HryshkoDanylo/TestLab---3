using RestSharp;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Net;

namespace lab_3.StepDefinitions
{
    [Binding]
    public class HTTPCatAPITestingStepDefinitions
    {
        static private RestClient client;
        static private RestRequest request;
        static private RestResponse response;
        static private int expectedStatusCode = 200;
        static private int expectedNotFoundStatusCode = 404;

        [Given(@"the HTTPCat API endpoint is ""([^""]*)""")]
        public void GivenTheHTTPCatAPIEndpointIs(string endpoint)
        {
            client = new RestClient(endpoint);
        }

        [When(@"I make a GET request for status code (.*)")]
        public void WhenIMakeAGETRequestForStatusCode(int statusCode)
        {
           
            request = new RestRequest($"/{statusCode}.jpg", Method.Get);
            response = client.Execute(request);
        }
        [Then(@"the response status code should be OK")]
        public void ThenTheResponseStatusCodeShouldBeOK()
        {
            Assert.That(Convert.ToInt32(expectedStatusCode), Is.EqualTo(Convert.ToInt32(response.StatusCode)));
        }

        [Then(@"the response status code should be NOT FOUND")]
        public void ThenTheResponseStatusCodeShouldBeNOTFOUND()
        {
            Assert.That(Convert.ToInt32(expectedNotFoundStatusCode), Is.EqualTo(Convert.ToInt32(response.StatusCode)));


        }
    } 
}
