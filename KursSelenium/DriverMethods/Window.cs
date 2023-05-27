using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Drawing;

namespace TestowyProjekt.DriverMethods
{
    class Window
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //ustawienie punktu startowego (od lewej górnej krawędzi) oraz wymiarów przeglądarki
            //driver.Manage().Window.Position = new System.Drawing.Point(8, 30);
            //driver.Manage().Window.Size = new System.Drawing.Size(1290, 730);
        }

        [Test]
        public void WindowPositionTest()
        {
            Point startingPoint = driver.Manage().Window.Position;
            Assert.AreEqual(new Point(10, 10), startingPoint, "Starting position is not as expected");
        }

        [Test]
        public void WindowSizeTest()
        {
            Size startingSize = driver.Manage().Window.Size;
            Assert.AreEqual(new Size(945, 1012), startingSize, "Size is not as expected");
        }

        [Test] 
        public void MinimizeWindowTest() {
            driver.Navigate().GoToUrl("https://www.google.pl");
            driver.Manage().Window.Minimize();
        }

        [Test]
        public void MaximizeWindowTest()
        {
            driver.Navigate().GoToUrl("https://www.google.pl");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void FullScreenWindowTest()
        {
            driver.Navigate().GoToUrl("https://www.google.pl");
            driver.Manage().Window.FullScreen();
        }

        [TearDown] 
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
