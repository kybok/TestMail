using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestMail.Page_s
{
    class HomePage
    {
        /// <summary>
        /// Контейнер для ввода логина
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Имя ящика']")]
        public IWebElement LoginContainer { get; set; }

        /// <summary>
        /// Кнопка "Ввести пароль" и "Войти"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[value='Ввести пароль']")]
        public IWebElement InputPasswordButton { get; set; }
        
        /// <summary>
        /// Контейнер для ввода пароля
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Пароль']")]
        public IWebElement PasswordContainer { get; set; }

        /// <summary>
        /// Кнопка "Войти"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[value='Ввести пароль']")]
        public IWebElement EntryButton { get; set; }
    }
}
