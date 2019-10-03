using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestMail.Page_s
{
    class MailPage
    {
       
        /// Кнопка "Написать письмо"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "span[data-title-shortcut='N']")]
        public IWebElement WriteMailButton { get; set; }

        
        /// <summary>
        /// Контейнер отправки "Кому"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[tabindex='100']")]
        public IWebElement WhomContainer { get; set; }
        
        /// <summary>
        /// Контейнер "Тела" письма
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "div[tabindex='505']")]
        public IWebElement BodyContainer { get; set; }
        
        /// <summary>
        /// Кнопка "Отправить письмо"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "span[title='Отправить']")]
        public IWebElement SendMailButton { get; set; }
    }
}
