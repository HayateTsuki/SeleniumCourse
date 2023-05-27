using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestowyProjekt.DriverMethods
{
    class Navigation
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GoToUrlTest()
        {
            Uri googleUrl = new Uri("https://google.pl");
            driver.Navigate().GoToUrl(googleUrl);
            string expectedUrl = "https://www.google.pl/";
            Assert.AreEqual(expectedUrl, driver.Url, "Url is not correct");
        }

        [Test]
        public void BackTest()
        {
            String googleUrl = "https://google.pl";
            String amazonUrl = "https://amazon.com";
            driver.Navigate().GoToUrl(googleUrl);
            driver.Navigate().GoToUrl(amazonUrl);
            driver.Navigate().Back();

            string expectedUrl = "https://www.google.pl/";
            Assert.AreEqual(expectedUrl, driver.Url, "Url is not correct");
        }

        [Test]
        public void ForwardTest()
        {
            String googleUrl = "https://google.pl";
            String amazonUrl = "https://amazon.com";
            driver.Navigate().GoToUrl(googleUrl);
            driver.Navigate().GoToUrl(amazonUrl);
            driver.Navigate().Back();
            driver.Navigate().Forward();

            string expectedUrl = "https://www.amazon.com/";
            Assert.AreEqual(expectedUrl, driver.Url, "Url is not correct");
        }

        [Test]
        public void RefreshTest()
        {
            String allegroUrl = "https://allegro.pl";
            driver.Navigate().GoToUrl(allegroUrl);
            Thread.Sleep(5000);
            driver.Navigate().Refresh();
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Close();
        }
    }
}
