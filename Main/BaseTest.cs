using NUnit.Framework;
using Aquality.Selenium.Browsers;
using TestProject1.Models;
using TestProject1.Util;
namespace TestProject1.Main
{
    public abstract class BaseTest
    {
        private static Browser browser;

        [SetUp]
        public void Setup()
        {
            DataTake.TakeConfigData();
            browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(DataContain.Mainpage);
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}
