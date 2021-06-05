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
    class Wyszukiwanie
    {
        public Wyszukiwanie()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Id, Using = "store_nav_search_term")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.Id, Using = "store_search_link")]
        public IWebElement btnSzukaj { get; set; }

        [FindsBy(How = How.Id, Using = "sort_by_dselect_container")]
        public IWebElement btnC { get; set; }

        [FindsBy(How = How.Id, Using = "Price_DESC")]
        public IWebElement btnD { get; set; }

        public PageObject Wyszukaj(string Search)
        {
            txtSearch.SendKeys(Search);

            btnSzukaj.Submit();
            btnC.Click();
            btnD.Click();

            return new PageObject();
        }
    }
}
