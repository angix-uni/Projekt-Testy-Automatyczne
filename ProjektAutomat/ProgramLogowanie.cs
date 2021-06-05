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
    class ProgramLogowanie
    {
        static void Main(string[] args)
        {
        }
        
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            
            PropertiesCollection.driver.Navigate().GoToUrl("https://store.steampowered.com/login/?redir=&redir_ssl=1&snr=1_4_4__global-header");
            Console.WriteLine("Otwarcie url");
        }

        [Test]
        public void ExecuteTest()
        {
            //strona logowania
            Logowanie login = new Logowanie();
            PageObject page = login.Login("test@gmail.com", "test123");

        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Zamknięcie");
        }
    }
}
