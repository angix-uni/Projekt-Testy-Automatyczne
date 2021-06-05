using Automat;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAutomat
{
    class ZmianaJezyka
    {
        public ZmianaJezyka()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "language_pulldown")]
        public IWebElement btnRozwin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Polski (Polish)")]
        public IWebElement btnZmien { get; set; }

        public PageObject DokonajZmiany()
        {

            btnRozwin.Click();
            btnZmien.Click();

            return new PageObject();
        }
    }
}
