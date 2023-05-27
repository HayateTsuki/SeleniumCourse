using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestowyProjekt.DriverMethods
{
    class TitleAndSource
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void RetrieveTitleTest() {
            String wikipediaUrl = "https://pl.wikipedia.org/";
            String wikipediaTitle = "Wikipedia, wolna encyklopedia";
            driver.Navigate().GoToUrl(wikipediaUrl);

            Assert.That(driver.Title, Is.EqualTo(wikipediaTitle), "Page title is not equal to expected");
        }

        [Test]
        public void RetrievePageSourceTest()
        {
            String googleUrl = "https://www.google.pl/";
            String metaContent = "url(/images/searchbox/desktop_searchbox_sprites318_hr.webp)";
            driver.Navigate().GoToUrl(googleUrl);

            Assert.IsTrue(driver.PageSource.Contains(metaContent), "Declared meta content was not found in the source page");
        }

        [TearDown] 
        public void QuitDriver() { 
            driver.Quit();
        }
    }
}
