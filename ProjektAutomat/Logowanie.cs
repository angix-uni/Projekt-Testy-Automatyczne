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
    class Logowanie
    {
        public Logowanie()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Id, Using = "input_username")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "input_password")]
        public IWebElement txtHaslo { get; set; }

        [FindsBy(How = How.Id, Using = "login_btn_signin")]
        public IWebElement btnZaloguj { get; set; }

        public PageObject Login(string Login, string Haslo)
        {
            txtEmail.SendKeys(Login);

            txtHaslo.SendKeys(Haslo);

            btnZaloguj.Click();

            return new PageObject();
        }
    }

}


