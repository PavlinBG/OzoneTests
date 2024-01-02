using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    public class AssertPageUrls
    {
        private RestClient _client;

        private const string BaseUrl = "https://www.ozone.bg";


        [SetUp]
        public void Setup()
        {
            _client = new RestClient(BaseUrl);

        }

        [Test]
        public void Test_NavigateToPoslednoDobaveni()
        {
            // Prepare the request for the homepage
            RestRequest homeRequest = new RestRequest("/", Method.Get);
            var homeResponse = _client.Execute(homeRequest);

            // Check status code for the homepage
            Assert.AreEqual(HttpStatusCode.OK, homeResponse.StatusCode, "Expected HTTP 200 OK for homepage");

            // Check if the link text is present in the response content
            string linkText = "Последно добавени";
            Assert.IsTrue(homeResponse.Content.Contains(linkText), $"Expected '{linkText}' link not found on the homepage");

            // Extract the URL for the "Последно добавени" link
            string linkUrl = ExtractLinkUrl(homeResponse.Content, linkText);

            // Navigate to the "Последно добавени" link
            RestRequest linkRequest = new RestRequest(linkUrl, Method.Get);
            var linkResponse = _client.Execute(linkRequest);

            // Check status code for the "Последно добавени" page
            Assert.AreEqual(HttpStatusCode.OK, linkResponse.StatusCode, $"Expected HTTP 200 OK for '{linkText}' page");
        }

        // Helper method to extract URL based on link text
        private string ExtractLinkUrl(string htmlContent, string linkText)
        {
            // Use HTML parsing libraries or regex to extract the URL corresponding to the link text
            // For simplicity, let's assume the URL format is consistent and use basic string manipulation
            int startIndex = htmlContent.IndexOf($"<a href=\"/", StringComparison.OrdinalIgnoreCase);
            int endIndex = htmlContent.IndexOf($">{linkText}</a>", StringComparison.OrdinalIgnoreCase);

            if (startIndex >= 0 && endIndex >= 0)
            {
                // Extract the URL
                int urlStart = startIndex + "<a href=\"/".Length;
                int urlLength = endIndex - urlStart;

                string linkUrl = htmlContent.Substring(urlStart, urlLength);
                return linkUrl;
            }

            throw new ArgumentException($"URL for '{linkText}' not found in the content");
        }



    }
}
