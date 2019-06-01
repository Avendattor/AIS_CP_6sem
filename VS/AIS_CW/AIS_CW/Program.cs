using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace AIS_CW
{
    class Autotest_Main
    {
        IWebDriver Browser;
        static void Main(string[] args)
        {
        }

        [Test]
        public void test_1_Password()
        {
            //declaring variable Browser
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Maximizing browser window
            Browser.Manage().Window.Maximize();
            //opening target site
            Browser.Navigate().GoToUrl("https://s22851.nubex.ru/");
            //finding password on page
            IWebElement Password = Browser.FindElement( By.XPath("/ html / body / div / div[3] / p[2] / strong")  );
            //ejecting password from element
            String PasswordText = Password.Text;
            //Searching field to insert password
            IWebElement InputPassword = Browser.FindElement( By.Id("password") );
            //filling field and sending password
            InputPassword.SendKeys( PasswordText + OpenQA.Selenium.Keys.Enter );
            //waiting 5 seconds 
            System.Threading.Thread.Sleep(5000);
            //quitting browser after test
            Browser.Quit();
        }

        [Test]
        public void test_2_Open_Contacts()
        {
            //declaring variable Browser
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Maximizing browser window
            Browser.Manage().Window.Maximize();
            //opening target site
            Browser.Navigate().GoToUrl("https://s22851.nubex.ru/");
            //finding password on page
            IWebElement Password = Browser.FindElement(By.XPath("/ html / body / div / div[3] / p[2] / strong"));
            //ejecting password from element
            String PasswordText = Password.Text;
            //Searching field to insert password
            IWebElement InputPassword = Browser.FindElement(By.Id("password"));
            //filling field and sending password
            InputPassword.SendKeys(PasswordText + OpenQA.Selenium.Keys.Enter);
            //Finding element with Contacts link
            IWebElement LinkContacts = Browser.FindElement( By.PartialLinkText("Контакты") ) ;
            //Clicking on element with Contacts link
            LinkContacts.Click();
            //waiting 5 seconds 
            System.Threading.Thread.Sleep(5000);
            //quitting browser after test
            Browser.Quit();
        }

        [Test]
        public void test_3_Open_Order()
        {
            //declaring variable Browser
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Maximizing browser window
            Browser.Manage().Window.Maximize();
            //opening target site
            Browser.Navigate().GoToUrl("https://s22851.nubex.ru/");
            //finding password on page
            IWebElement Password = Browser.FindElement(By.XPath("/ html / body / div / div[3] / p[2] / strong"));
            //ejecting password from element
            String PasswordText = Password.Text;
            //Searching field to insert password
            IWebElement InputPassword = Browser.FindElement(By.Id("password"));
            //filling field and sending password
            InputPassword.SendKeys(PasswordText + OpenQA.Selenium.Keys.Enter);
            //Finding element with Order link
            IWebElement LinkOrder = Browser.FindElement(By.PartialLinkText("Заказать зал"));
            //Clicking on element with Order link
            LinkOrder.Click();
            //waiting 5 seconds 
            System.Threading.Thread.Sleep(5000);
            //quitting browser after test
            Browser.Quit();
        }
    }
}