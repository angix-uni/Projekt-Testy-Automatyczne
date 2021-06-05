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
    class ProgramPomoc
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
            RozwiazProblem rozwiaz = new RozwiazProblem();
            PageObject page = rozwiaz.Wybierz("the sims 4");

        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Zamknięcie");
        }
    }
}
