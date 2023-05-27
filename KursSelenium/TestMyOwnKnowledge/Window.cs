using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace TestowyProjekt.TestMyOwnKnowledge
{
    class Window
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Size = new Size(854, 480);
            driver.Manage().Window.Position = new Point(445, 30);
        }

        [Test]
        public void WindowSizeTest()
        {
            Size actualSize = driver.Manage().Window.Size;

            Assert.AreEqual(new Size(854, 480), actualSize, "Window size is different than expected");
        }

        [Test]
        public void WindowPositionTest()
        {
            Point actualPosition = driver.Manage().Window.Position;

            Assert.AreEqual(new Point(445, 30), actualPosition, "Window position is different than expected");
        }

        [TearDown] 
        public void TearDown() { 
            driver.Quit();
        }
    }
}
