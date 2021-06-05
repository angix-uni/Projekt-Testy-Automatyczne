using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomatyczny;

namespace Automat
{
    class PageObject
    {
        public PageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}
