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
    class ProgramZmiana
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
            ZmianaJezyka zmien = new ZmianaJezyka();
            PageObject page = zmien.DokonajZmiany();

        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Zamknięcie");
        }
    }
}
