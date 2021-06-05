using Automat;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAutomat
{
    class ProgramWyszukiwanie
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();


            PropertiesCollection.driver.Navigate().GoToUrl("https://store.steampowered.com/");
            Console.WriteLine("Otwarcie url");
        }

        [Test]
        public void ExecuteTest()
        {
            //strona wyszukiwania
            Wyszukiwanie wyszukaj = new Wyszukiwanie();
            PageObject page = wyszukaj.Wyszukaj("the sims 4");

        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Zamknięcie");
        }
    }
}
