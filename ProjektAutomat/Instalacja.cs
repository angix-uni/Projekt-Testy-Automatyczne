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
    class Instalacja
    {
        public Instalacja()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Install Steam")]
        public IWebElement btnSupp { get; set; }

        [FindsBy(How = How.LinkText, Using = "Visit the Community")]
        public IWebElement btnIn { get; set; }

        [FindsBy(How = How.Id, Using = "SearchPlayers")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "community_home_search_players_image")]
        public IWebElement btnP { get; set; }





        public PageObject SprawdzInstalacje(string Search)
        {

            btnSupp.Click();
            btnIn.Click();
            txtSearch.SendKeys(Search);
            btnP.Click();

            return new PageObject();
        }
    }
}
