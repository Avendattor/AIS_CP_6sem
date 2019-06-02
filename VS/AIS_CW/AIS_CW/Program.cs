using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace Cinema
{
    class Autotest_Main
    {
        IWebDriver Browser;
        static void Main(string[] args)
        {
        }

        [Test]
        public void test_0_Password()
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
            //System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void test_1_Switching_Pages()
        {
            
            //Finding element with Contacts link
            IWebElement LinkContacts = Browser.FindElement( By.PartialLinkText("Контакты") ) ;
            //Clicking on element with Contacts link
            LinkContacts.Click();
            //waiting 5 seconds 
            //System.Threading.Thread.Sleep(5000);
            //Finding element with Contacts link
            LinkContacts = Browser.FindElement(By.PartialLinkText("Контакты"));
            //Clicking on element with Order link
            LinkContacts.Click();
            //waiting 3 seconds 
            //System.Threading.Thread.Sleep(3000);
            //Finding element with Order link
            IWebElement LinkOrder = Browser.FindElement(By.PartialLinkText("Заказать зал"));
            //Clicking on element with Order link
            LinkOrder.Click();
            //waiting 5 seconds 
            //System.Threading.Thread.Sleep(5000);
            //Finding element with Order link
            LinkOrder = Browser.FindElement(By.PartialLinkText("Заказать зал"));
            //Clicking on element with Order link
            LinkOrder.Click();
            //Finding element with About link
            IWebElement LinkAbout = Browser.FindElement(By.PartialLinkText("О нас"));
            //Clicking on element with About link
            LinkAbout.Click();
            //Finding element with Services link
            IWebElement LinkServices = Browser.FindElement(By.PartialLinkText("Услуги"));
            //Clicking on element with Services link
            LinkServices.Click();
            //Finding element with Films link
            IWebElement LinkFilms = Browser.FindElement(By.PartialLinkText("Фильмы"));
            //Clicking on element with Films link
            LinkFilms.Click();
        }

        [Test]
        public void test_2_Make_Order()
        {
            //Finding element with Order link
            IWebElement LinkOrder = Browser.FindElement(By.PartialLinkText("Заказать зал"));
            //Clicking on element with Order link
            LinkOrder.Click();
            //Searching field to insert FIO
            IWebElement FIO = Browser.FindElement( By.Name ("form_data[1]") );
            //filling FIO field 
            FIO.SendKeys("Big Smoke");
            //Searching field to insert Phone
            IWebElement Phone = Browser.FindElement(By.Name("form_data[2]"));
            //filling Phone field 
            Phone.SendKeys("88005553535");
            //Searching field to insert Call_time
            IWebElement Call_time = Browser.FindElement(By.Name("form_data[7]"));
            //clicking Call_time field 
            Call_time.Click();
            //Searching field to insert Call_time_Variants
            IWebElement Call_time_Variants = Browser.FindElement(By.CssSelector ("#form_5108 > form > div.formPlain > div:nth-child(3) > div:nth-child(2) > select > option:nth-child(5)"));
            //clicking Call_time_Variants field 
            Call_time_Variants.Click();
            //Searching field to insert email
            IWebElement email = Browser.FindElement(By.Name("form_data[3]"));
            //filling email field 
            email.SendKeys("order@mail.com");
            //Searching field to insert date
            IWebElement date = Browser.FindElement(By.Name("calendar"));
            //filling date field 
            date.SendKeys("09092019");
            //Searching field to insert comment
            IWebElement comment = Browser.FindElement(By.Name("form_data[5]"));
            //filling comment field 
            comment.SendKeys("I’ll have 2 numbers 9s," + OpenQA.Selenium.Keys.Enter +
                "Number 9 large," + OpenQA.Selenium.Keys.Enter +
                "Number 6 with extra dip," + OpenQA.Selenium.Keys.Enter +
                "Number 7," + OpenQA.Selenium.Keys.Enter +
                "2 Number 45," + OpenQA.Selenium.Keys.Enter +
                "One with cheese," + OpenQA.Selenium.Keys.Enter +
                "And a Large soda");
            //Searching checkbox to check
            IWebElement checkbox = Browser.FindElement(By.Name("form_data[6]"));
            //checking checkbox
            checkbox.Click();
            //Searching Submit button
            IWebElement Submit = Browser.FindElement(By.Name("btn-send"));
            //Clicking Submit button
            //Submit.Click();
        }

        [Test]
        public void test_3_Write_Feedback()
        {
            //Finding element with About link
            IWebElement LinkAbout = Browser.FindElement(By.PartialLinkText("О нас"));
            //Clicking on element with About link
            LinkAbout.Click();
            //Finding element with Feedback link
            IWebElement LinkFeedback = Browser.FindElement(By.PartialLinkText("Оставить отзыв"));
            //Clicking on element with Feedback link
            LinkFeedback.Click();
            //Searching field to insert FIO
            IWebElement FIO = Browser.FindElement(By.Name("form_data[1]"));
            //filling FIO field 
            FIO.SendKeys("Zubenko Mihail Petrovich");
            //Searching field to insert Phone
            IWebElement Phone = Browser.FindElement(By.Name("form_data[2]"));
            //filling Phone field 
            Phone.SendKeys("88005553535");
            //Searching field to insert email
            IWebElement email = Browser.FindElement(By.Name("form_data[3]"));
            //filling email field 
            email.SendKeys("feedback@mail.com");
            //Searching checkbox to check
            IWebElement checkbox = Browser.FindElement(By.Name("form_data[5]"));
            //checking checkbox
            checkbox.Click();
            //Searching field to insert Feedback
            IWebElement Feedback = Browser.FindElement(By.Name("form_data[4]"));
            //filling Feedback field 
            Feedback.SendKeys("Кладмен *****, пришлось покупать билет в кинотеатр, чтобы забрать товар. " + OpenQA.Selenium.Keys.Enter + 
                "А так кинотеатр неплохой, фильмы классные, попкорн вкусный.");
            //Searching Submit button
            IWebElement Submit = Browser.FindElement(By.Name("btn-send"));
            //Clicking Submit button
            //Submit.Click();

        }

        [Test]
        public void test_4_Ask_Question()
        {
            //Finding element with Contacts link
            IWebElement LinkContacts = Browser.FindElement(By.PartialLinkText("Контакты"));
            //Clicking on element with Order link
            LinkContacts.Click();
            //Searching field to insert FIO
            IWebElement FIO = Browser.FindElement(By.Name("form_data[1]"));
            //filling FIO field 
            FIO.SendKeys("Zubenko Mihail Petrovich");
            //Searching field to insert email
            IWebElement email = Browser.FindElement(By.Name("form_data[2]"));
            //filling email field 
            email.SendKeys("question@mail.com");
            //Searching field to insert comment
            IWebElement comment = Browser.FindElement(By.Name("form_data[3]"));
            //filling comment field 
            comment.SendKeys("I can't find on your site 2 numbers 9s," + OpenQA.Selenium.Keys.Enter +
                "Number 9 large," + OpenQA.Selenium.Keys.Enter +
                "Number 6 with extra dip," + OpenQA.Selenium.Keys.Enter +
                "Number 7," + OpenQA.Selenium.Keys.Enter +
                "2 Number 45," + OpenQA.Selenium.Keys.Enter +
                "One with cheese," + OpenQA.Selenium.Keys.Enter +
                "And a Large soda");
            //Searching Send button
            IWebElement Send = Browser.FindElement(By.Name("btn-send"));
            //Clicking Send button
            //Send.Click();

        }



        [Test]
        public void test_LAST_Close()
        {
            //waiting 3 seconds 
            System.Threading.Thread.Sleep(3000);
            //quitting browser after test
            Browser.Quit();
        }
    }
}