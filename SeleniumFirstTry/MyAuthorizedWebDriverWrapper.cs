using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTry
{
	public class MyAuthorizedWebDriverWrapper : IDisposable
	{
        private IReadOnlyCollection<Cookie> cookies;
        public IWebDriver webDriver;
        public WebDriverWait wait;

        public MyAuthorizedWebDriverWrapper()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            this.Auth();
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
        }

        private void Auth()
        {
            //Auth



            this.cookies = webDriver.Manage().Cookies.AllCookies;
        }

		public void Dispose()
		{
            webDriver.Quit();
            webDriver.Dispose();
		}
	}
}
