using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace TestowyProjekt.DriverMethods
{
    class QuitAndClose
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GoToGoogleTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
        }

        [TearDown] 
        public void TearDown() {
            //ubija ChromeDrivera
            driver.Quit();
            
            //Zamyka zakładkę/nowe okno
            //driver.Close();
        }
    }
}
