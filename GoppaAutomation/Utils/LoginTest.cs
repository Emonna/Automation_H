using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GoppaAutomation.StepGeneration.Utils
{
    public class LoginTest
    {
        //private readonly userName = By.ID();
        //private readonly LastName = By.ID()

        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = " https://goppa.benivo.com/goppa/signup";
        }
        public void TestLogin()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.FindElement(By.XPath("//button[contains(.,'Login')]"));

            driver.FindElement(By.Id("username")).Click();

            //// Find the element that's ID attribute is 'log' (Username)
            //// Enter Username on the element found by above desc.
            //driver.FindElement(By.Id("log")).SendKeys("testuser_1");

            //// Find the element that's ID attribute is 'pwd' (Password)
            //// Enter Password on the element found by the above desc.
            //driver.FindElement(By.Id("pwd")).SendKeys("Test@123");

            //// Now submit the form.
            //driver.FindElement(By.Id("login")).Click();

            //// Find the element that's ID attribute is 'account_logout' (Log Out)
            //driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();

            //// Close the driver
            //driver.Quit();

        }
    }
}

