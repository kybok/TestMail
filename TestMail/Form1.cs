using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestMail.Page_s;
using Keys = System.Windows.Forms.Keys;

namespace TestMail
{
    public partial class Form1 : Form
    {
        #region Переменные
        private IWebDriver browser;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser = new ChromeDriver();                                               
            browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);            //Ставим таймер загрузки страницы 
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);        //Ставим таймер ожидания элемента  
            browser.Navigate().GoToUrl("https://mail.ru/");                             
            HomePage homePage = new HomePage();                                         
            PageFactory.InitElements(browser, homePage);

            homePage.LoginContainer.SendKeys("ivanovivantesting@mail.ru");              //Логин почты
            homePage.EntryButton.Click();
            homePage.PasswordContainer.SendKeys("TOGES1265");                           //Пароль почты
            homePage.EntryButton.Click();

            MailPage mailPage = new MailPage();
            PageFactory.InitElements(browser,mailPage);

            try
            {
                browser.FindElement(By.CssSelector("div[class='scrollable__container']"));
                mailPage.WriteMailButton.Click();
            }
            catch{ browser.FindElement(By.CssSelector("div[class='scrollable__container']")).SendKeys("N");}
            
            mailPage.WhomContainer.SendKeys("ivanovivantesting@mail.ru" + "\n");
            mailPage.BodyContainer.SendKeys("Привет!");
            mailPage.SendMailButton.Click();

        }
    }
}
