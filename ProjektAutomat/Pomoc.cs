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
    class RozwiazProblem
    {
        public RozwiazProblem()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "SUPPORT")]
        public IWebElement btnSupp { get; set; }

        [FindsBy(How = How.LinkText, Using = "Games, Software, etc.")]
        public IWebElement btnAcc { get; set; }

        [FindsBy(How = How.Id, Using = "help_search_support_input")]
        public IWebElement txtSearch { get; set; }


        public PageObject Wybierz(string input)
        {
            btnSupp.Click();
            btnAcc.Click();
            txtSearch.SendKeys(input);
            return new PageObject();
        }
    }
}
