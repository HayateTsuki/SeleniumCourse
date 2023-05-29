
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestowyProjekt.LocatingElements
{
    class FindingElementsEasyWay
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [Test]
        public void LocatingElementsTest()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/");
            IWebElement search = driver.FindElement(By.Id("woocommerce-product-search-field-0"));
            search.SendKeys("el gouna");
            search.Submit();
            Assert.AreEqual("Egipt – El Gouna – FakeStore", driver.Title, "Page title is not correct");
        }

        [Test]
        public void LocatingElementsByLink()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/product/fuerteventura-sotavento/");
            IWebElement addToBusketButton = driver.FindElement(By.Name("add-to-cart"));
            addToBusketButton.Click();
            IWebElement goToBusketLink = driver.FindElement(By.LinkText("Zobacz koszyk"));
            goToBusketLink.Click();
            //IWebElement goToPaymentsButton = driver.FindElement(By.LinkText("\r\n\tPrzejdź do płatności"));
            TestDelegate findGoToPaymentLink = new TestDelegate(FindGoToPaymentLink);
            Assert.DoesNotThrow(findGoToPaymentLink, "Go to payment link was not found. ");
            //goToPaymentsButton.Click();

           // Assert.AreEqual("Zamówienie – FakeStore", driver.Title, "Page title is not correct");
        }

        private void FindGoToPaymentLink()
        {
            driver.FindElement(By.LinkText(" Przejdź do płatności"));
        }

        [TearDown] 
        public void QuitDriver() { 
            driver.Quit();
        }
    }
}
