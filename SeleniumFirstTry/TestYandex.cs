using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SeleniumFirstTry
{
	//[CollectionDefinition("Non-Parallel Collection", DisableParallelization = true)]
	public class TestYandex : IClassFixture<MyAuthorizedWebDriverWrapper>
	{
		IReadOnlyCollection<Cookie> cookies;
		private MyAuthorizedWebDriverWrapper webDriverWrapper;

		private readonly ITestOutputHelper testOutput;

		// Dependency injection
		public TestYandex(MyAuthorizedWebDriverWrapper fixture, 
			ITestOutputHelper testOutput)
		{
			this.webDriverWrapper = fixture;
			this.testOutput = testOutput;
		}

		[Fact]
		[Trait("Category", "Smoke")]
		public async  void testAuth()
		{
			webDriverWrapper.webDriver.Navigate().GoToUrl("https://yandex.ru/");
			//var searchInput = driver.FindElement(By.XPath("//*[@id='text']"));


			webDriverWrapper.wait.Until(d => d.FindElement(By.XPath("//*[@id='text']")));
			webDriverWrapper.wait
				.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='text']")));

			var searchInput = webDriverWrapper.webDriver.FindElement(By.XPath("//*[@id='text']"));
			searchInput.SendKeys("google");
			searchInput.SendKeys(Keys.Enter);

			testOutput.WriteLine("Some information");
			await Task.Delay(10000);
		}

		[Fact]
		[Trait("Category", "Smoke")]
		public void testAuth1()
		{
			webDriverWrapper.webDriver.Navigate();
		}
	}
}
