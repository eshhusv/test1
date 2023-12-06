using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        private WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://rusprolife.ru");

            Assert.AreEqual(driver.Title, "За жизнь");

            driver.Quit();
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://rusprolife.ru");

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[1]/a[1]"));
            bool status = element.Displayed;
            Assert.IsTrue(status);

            driver.Quit();
        }

        [Test]
        public void Test3()
        {
            driver.Navigate().GoToUrl("https://rusprolife.ru");

            var button = driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div[1]/div[1]"));
            button.Click();

            driver.Quit();
        }

        [Test]
        public void Test4()
        {
            driver.Navigate().GoToUrl("https://rusprolife.ru");

            driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/form/fieldset/input")).SendKeys("Ultralight beam");

            driver.Quit();
        }

        [Test]
        public void Test5()
        {
            driver.Navigate().GoToUrl("https://rusprolife.ru");

            var button = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div[1]/a[1]"));
            button.Click();

            driver.Quit();
        }

    }
}