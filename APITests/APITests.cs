using RestSharp;
using System.Net;

namespace APITests
{
    public class Tests
    {

        private RestClient _client;

        private const string BaseUrl = "https://www.ozone.bg";


        [SetUp]
        public void Setup()
        {
            _client = new RestClient(BaseUrl);

        }

        [Test]
        public void TestMainPageLoad()
        {
             RestRequest request = new RestRequest("/", Method.Get);

             var response = _client.Execute(request);

             Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);


        }

        [Test]
        public void Test_TitleOfMainPage()
        {
            RestRequest request = new RestRequest("/", Method.Get);

            var response = _client.Execute(request);
            Assert.IsTrue(response.Content.Contains("<title>Mагазин за игри, книги, геймърски аксесоари и играчки | Ozone.bg</title>"));
        }

        [Test]
        public void Test_StatusCodeForInvalidPage()
        {
            RestRequest request = new RestRequest("/nonexistentpage", Method.Get);

            var response = _client.Execute(request);
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.NotFound);
        }





        [Test]
        public void Test_LoginPageRedirect()
        {
            RestRequest request = new RestRequest("/protectedpage", Method.Get);
            var response = _client.Execute(request);
            Assert.IsTrue(response.ResponseUri.AbsolutePath.Contains("login"));
        }

        [Test]
        public void Test_ImagesLoading()
        {
            RestRequest request = new RestRequest("/", Method.Get);
            var response = _client.Execute(request);
            Assert.IsTrue(response.Content.Contains("<img src=\"https://www.ozone.bg/landing/vreme_za_podaruci/images/logo.png\""));
        }



 
        [Test]
        public void Test_NavigationLinks()
        {
            RestRequest request = new RestRequest("/", Method.Get);

            var response = _client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Expected HTTP 200 OK");

            string expectedLink = "<a href=\"/posledno-dobaveni/\">Последно добавени</a>";

            Assert.IsTrue(response.Content.Contains(expectedLink), "Expected link not found in the response");
        }


        [Test]
        public void Test_LoginFormExists()
        {
            RestRequest request = new RestRequest("/customer/account/loginPost/", Method.Get);
            var response = _client.Execute(request);
            Assert.IsTrue(response.Content.Contains("<form id=\"login-form\""));
        }

        [Test]
        public void TestProductSearch()
        {
            RestRequest request = new RestRequest("/search?q=product", Method.Get);
            var response = _client.Execute(request);
            Assert.IsTrue(response.Content.Contains("Какво ще търсиш днес?"));
        }





        [Test]
        public void TestLogoutFunctionality()
        {
            // Assuming the logout action sends a request to "/logout"
            RestRequest request = new RestRequest("/logout", Method.Post);
            // Include any necessary logout parameters

            var response = _client.Execute(request);
            Assert.IsTrue(response.Content.Contains("You have been logged out"));
        }


    }
}