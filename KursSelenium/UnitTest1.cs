using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KursSelenium
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.pl");
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}