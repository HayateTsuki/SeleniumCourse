using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestowyProjekt.TestMyOwnKnowledge
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
        public void TestBackNavigation() {
            String wikipediaUrl = "https://pl.wikipedia.org/";
            String nasaUrl = "https://www.nasa.gov/";
            driver.Navigate().GoToUrl(wikipediaUrl);
            driver.Navigate().GoToUrl(nasaUrl);
            driver.Navigate().Back();

            String expectedUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            Assert.That(driver.Url, Is.EqualTo(expectedUrl), "Adres URL jest inny niż się spodziewano po wykonaniu cofnięcia");
        }

        [Test]
        public void TestBackAndForwardNavigation()
        {
            String wikipediaUrl = "https://pl.wikipedia.org/";
            String nasaUrl = "https://www.nasa.gov/";
            driver.Navigate().GoToUrl(wikipediaUrl);
            driver.Navigate().GoToUrl(nasaUrl);
            driver.Navigate().Back();
            driver.Navigate().Forward();

            String expectedUrl = "https://www.nasa.gov/";
            Assert.That(driver.Url, Is.EqualTo(expectedUrl), "URL adress is not equal to expected");
        }

        [TearDown] 
        public void QuitDriver() {
            driver.Quit();
        }
    }
}
