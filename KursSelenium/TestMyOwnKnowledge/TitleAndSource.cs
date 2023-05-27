

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestowyProjekt.TestMyOwnKnowledge
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
        public void TitleTest() {
            driver.Navigate().GoToUrl("http://wikipedia.es/");
            String esWikipediaTitle = "Wikipedia, la enciclopedia libre";

            Assert.AreEqual(esWikipediaTitle, driver.Title, "Spain Wikipedia title is not equal to expected");
        }

        [Test]
        public void SourceTest()
        {
            driver.Navigate().GoToUrl("http://wikipedia.es/");
            String metaContent = "lang=\"es\"";

            Assert.IsTrue(driver.PageSource.Contains(metaContent), "Searched meta content doesn't exist in page source");
        }

        [TearDown] 
        public void QuitDriver() { 
            driver.Quit();
        }
    }
}
