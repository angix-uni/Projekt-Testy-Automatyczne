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
    class ProgramInstalacja
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
            Instalacja instalacja = new Instalacja();
            PageObject page = instalacja.SprawdzInstalacje("test");

        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Zamknięcie");
        }
    }
}
