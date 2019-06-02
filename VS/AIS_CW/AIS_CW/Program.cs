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
        public void test_5_Order_Tickets()
        {
            //Finding element with Films link
            IWebElement LinkFilms = Browser.FindElement(By.PartialLinkText("Фильмы"));
            //Clicking on element with Films link
            LinkFilms.Click();
            //Finding element with Arthouse link
            IWebElement LinkArthouse = Browser.FindElement(By.PartialLinkText("Артхаус"));
            //Clicking on element with Arthouse link
            LinkArthouse.Click();
            //Finding element with BTBR to add to cart
            IWebElement LinkBTBRToCart = Browser.FindElement(By.XPath ("/html/body/div[2]/div[2]/div[2]/div/div[3]/div/div[1]/div[2]/div[2]/div[2]/form/button"));
            //Clicking on element with BTBR link - adding to cart
            LinkBTBRToCart.Click();
            //waiting for 2 seconds 
            System.Threading.Thread.Sleep(2000);
            //Finding element with Continue link
            IWebElement LinkContinue = Browser.FindElement(By.Id("product_added_close"));
            //Clicking on element with Continue link
            LinkContinue.Click();
            //waiting for 2 seconds 
            System.Threading.Thread.Sleep(2000);
            //Finding element with Gays Film link
            IWebElement LinkFilmGays = Browser.FindElement(By.PartialLinkText("Геи"));
            //Clicking on element with Gays Film link
            LinkFilmGays.Click();
            //Finding element with Gays to add to cart
            IWebElement LinkGaysToCart = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div/div[2]/div[1]/div[3]/div[2]/form/button"));
            //Clicking on element with Gays link - adding to cart
            LinkGaysToCart.Click();
            //waiting for 2 seconds 
            System.Threading.Thread.Sleep(2000);
            //Finding element with Cart link
            IWebElement LinkToCart = Browser.FindElement(By.PartialLinkText("Перейти в корзину"));
            //Clicking on element to go to the Cart
            LinkToCart.Click();
            //Finding element with adding Gays tickets link
            IWebElement ButtonAddGays = Browser.FindElement(By.XPath("//*[@id=\"cartEdit\"]/div[1]/table/tbody/tr[3]/td[3]/a[2]"));
            //Clicking on element with adding Gays tickets link
            ButtonAddGays.Click();
            //Clicking on element with adding Gays tickets link
            ButtonAddGays.Click();
            //Clicking on element with adding Gays tickets link
            ButtonAddGays.Click();
            //Clicking on element with adding Gays tickets link
            ButtonAddGays.Click();
            //waiting for 2 seconds 
            System.Threading.Thread.Sleep(5000);
            //Finding element with OrderTickets link
            IWebElement ButtonOrderTickets = Browser.FindElement(By.PartialLinkText("Оформить заказ"));
            //Clicking on element with OrderTickets link
            ButtonOrderTickets.Click();
            //Searching field to insert FIO
            IWebElement FieldFIO = Browser.FindElement(By.Name("form_data[1]"));
            //filling FIO field 
            FieldFIO.SendKeys("Zubenko Mihail Petrovich");
            //Searching field to insert Phone
            IWebElement FieldPhone = Browser.FindElement(By.Name("form_data[3]"));
            //filling Phone field 
            FieldPhone.SendKeys("88005553535");
            //Searching field to insert email
            IWebElement FieldEmail = Browser.FindElement(By.Name("form_data[4]"));
            //filling email field 
            FieldEmail.SendKeys("tickets_order@mail.com");
            //Finding element with Cash RadioButton
            IWebElement RadioButtonCash = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div[4]/form/div/div[4]/div[2]/label/input"));
            //Clicking on element with Cash RadioButton
            RadioButtonCash.Click();
            //Finding element with Delivery RadioButton
            IWebElement RadioButtonDelivery = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div[4]/form/div/div[5]/div[2]/label/input"));
            //Clicking on element with Delivery RadioButton
            RadioButtonDelivery.Click();
            //Searching field to insert Address
            IWebElement Address = Browser.FindElement(By.Name("form_data[8]"));
            //filling Address field 
            Address.SendKeys("г. Петрозаводск, ул. Зайцева, 32");
            //Searching field to insert TicketOrderComment
            IWebElement TicketOrderComment = Browser.FindElement(By.Name("form_data[9]"));
            //filling TicketOrderComment field 
            TicketOrderComment.SendKeys("Побыстрее, пожалуйста");
            //Searching Send button
            IWebElement ButtonSend = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div[4]/form/button"));
            //Clicking Send button
            //ButtonSend.Click();
        }

        [Test]
        public void test_6_Write_Review()
        {
            //Searching field to insert Query
            IWebElement InputPassword = Browser.FindElement(By.Id("textGray"));
            //filling field and sending Query
            InputPassword.SendKeys("Геи" + OpenQA.Selenium.Keys.Enter);
            //Finding element with Gays Film link
            IWebElement LinkFilmGays = Browser.FindElement(By.PartialLinkText("Геи"));
            //Clicking on element with Gays Film link
            LinkFilmGays.Click();
            //Finding element with OrderTickets button link 
            IWebElement ButtonNewReview = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div/div[2]/div[2]/a[2]"));
            //Clicking on element with OrderTickets button link
            ButtonNewReview.Click();
            //Searching field to insert FIO
            IWebElement FieldFIO = Browser.FindElement(By.Name("signature"));
            //filling FIO field 
            FieldFIO.SendKeys("Сибас Валентинович Валерьянов");
            //Searching field to insert Email
            IWebElement FieldEmail = Browser.FindElement(By.Name("email"));
            //filling Email field 
            FieldEmail.SendKeys("FilmReview@mail.com");
            //Finding element with one star
            IWebElement ButtonOneStar = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div[3]/form/div[3]/div[2]/label[5]"));
            //Clicking on element with one star
            ButtonOneStar.Click();
            //Searching ExpTime > year radio button
            IWebElement RadioButtonMoreThanOneYear = Browser.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div[3]/form/div[4]/div[2]/div[3]/label/input"));
            //Clicking ExpTime > year radio button
            RadioButtonMoreThanOneYear.Click();
            //Searching field to insert Pros
            IWebElement FieldPros = Browser.FindElement(By.Name("positive"));
            //filling Pros field 
            FieldPros.SendKeys("Нет");
            //Searching field to insert Cons
            IWebElement FieldCons = Browser.FindElement(By.Name("negative"));
            //filling Cons field 
            FieldCons.SendKeys("Тоже нет");
            //Finding element with Comment link
            IWebElement FieldComment = Browser.FindElement(By.Name("comment"));
            //Clicking on element with Comment link
            FieldComment.SendKeys("Да я и не смотрел этот фильм, в принципе, " + OpenQA.Selenium.Keys.Enter +
                "он мне просто не нравится из-за названия.");
            //Searching Send button
            IWebElement ButtonAddReview = Browser.FindElement(By.Name("send"));
            //Clicking Send button
            //ButtonAddReview.Click();
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